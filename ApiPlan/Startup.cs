using System;
using System.IO;
using System.Reflection;
using FluentValidation;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using WmsApi;
using WmsApi.Domain;

namespace ApiPlan
{
	public class Startup
	{
		private readonly string apiBasePath = "plan";

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			var connectionString = Configuration.GetConnectionString("DefaultConnection");

			var serverVersion = new MySqlServerVersion(new Version(5, 7, 27));
			services.AddDbContext<WmspcrContext>(options => options.UseMySql(connectionString, serverVersion));

			// register AutoMapper profiles
			services.AddAutoMapper(typeof(WmspcrContext));

            services.AddSignalR();

            // register validation
            services.Scan(x =>
				x.FromAssembliesOf(typeof(WmspcrContext))
					.AddClasses(c => c.AssignableToAny(typeof(IValidator<>)))
					.AsImplementedInterfaces()
			);

			services.AddCors(option => option.AddPolicy("cors", policy => policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("*")));
			services.AddControllers(options =>
			{
				// remove formatter that turns nulls into 204 - No Content responses
				// this formatter breaks Http response JSON parsing
				options.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
				options.Filters.Add<ActionFilter>();
			}).AddNewtonsoftJson();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiPlan", Version = "v1" });
				// 获取xml文件名
				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				// 获取xml文件路径
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				//是否显示注释
				c.IncludeXmlComments(xmlPath, true);
			});

			services.AddMassTransit(x =>
			{
				x.AddConsumer<PlanConsumer>();
				x.AddConsumer<ToClientConsumer>();
                x.UsingRabbitMq((context, cfg) =>
				{
					cfg.Host("10.11.1.3", "wms", h =>
					{
						h.Username("wms");
						h.Password("P@ssw0rd");
					});

					cfg.ReceiveEndpoint("Queue.Api.Plan", e =>
					{
						e.Durable = false;
						e.AutoDelete = true;
						e.ConfigureConsumer<PlanConsumer>(context); 
						e.ConfigureConsumer<ToClientConsumer>(context);
                    });
				});
			});
			services.AddSingleton<MbsProxy>();
			services.AddHealthChecks().AddCheck<DbHealthCheck>("sql_check");
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			//if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger(c =>
				{
					c.RouteTemplate = apiBasePath + "/{documentName}/swagger.json";
				});

				app.UseSwaggerUI(c =>
				{
					c.SwaggerEndpoint($"/{apiBasePath}/v1/swagger.json", $"作业计划 API");
					c.RoutePrefix = $"{apiBasePath}";
				});
			}
			app.UseCors("cors");

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				endpoints.MapHealthChecks($"/{apiBasePath}/health");
                endpoints.MapHub<ChatHub>($"/{apiBasePath}/api/chathub");
            });
		}
	}
}
