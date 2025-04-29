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
using NLog.Extensions.Logging;
using NLog.Web;
using Refit;
using WmsApi;
using WmsApi.Domain;

namespace ApiTracker
{
	public class Startup
	{
		private readonly string apiBasePath = "tracker";

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			var connectionString = Configuration.GetConnectionString("DefaultConnection");

			services.AddLogging(logging =>
			{
				logging.AddNLog();
			});

			var serverVersion = new MySqlServerVersion(new Version(5, 7, 27));
			services.AddDbContext<WmspcrContext>(options => options.UseMySql(connectionString, serverVersion));

			// register AutoMapper profiles
			services.AddAutoMapper(typeof(WmspcrContext));

			services.AddSignalR();

			services.AddScoped<CustomHeaderHandler>();

			services.AddRefitClient<IGateApi>()
				.ConfigureHttpClient(c =>
				{
					c.BaseAddress = new Uri("https://10.11.1.15");
				})
				.ConfigurePrimaryHttpMessageHandler<CustomHeaderHandler>();

			services.AddRefitClient<IGateTokenApi>()
				.ConfigureHttpClient(c =>
				{
					c.BaseAddress = new Uri("http://10.11.1.15");
				})
				.ConfigurePrimaryHttpMessageHandler<CustomHeaderHandler>();

			// register validation
			services.Scan(x =>
				x.FromAssembliesOf(typeof(WmspcrContext))
					.AddClasses(c => c.AssignableToAny(typeof(IValidator<>)))
					.AsImplementedInterfaces()
			);

			services.AddCors(option => option.AddPolicy("cors",
				policy => policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("*")));

			services.AddControllers(options =>
			{
				// remove formatter that turns nulls into 204 - No Content responses
				// this formatter breaks Http response JSON parsing
				options.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
				options.Filters.Add<ActionFilter>();
			}).AddNewtonsoftJson();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiTracker", Version = "v1" });
				// 获取xml文件名
				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				// 获取xml文件路径
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				//是否显示注释
				c.IncludeXmlComments(xmlPath, true);
			});

			services.AddMassTransit(x =>
			{
				x.AddConsumer<TrackerConsumer>();
				x.AddConsumer<ToHoldConsumer>();
                x.UsingRabbitMq((context, cfg) =>
				{
					cfg.Host("10.11.1.3", "wms", h =>
					{
						h.Username("wms");
						h.Password("P@ssw0rd");
					});

					cfg.ReceiveEndpoint("Queue.Api.Tracker", e =>
					{
						e.Durable = false;
						e.AutoDelete = true;
						e.ConfigureConsumer<TrackerConsumer>(context);
						e.ConfigureConsumer<ToHoldConsumer>(context);
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
					c.SwaggerEndpoint($"/{apiBasePath}/v1/swagger.json", $"物料跟踪 API");
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
