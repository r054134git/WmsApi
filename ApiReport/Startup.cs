using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using WmsApi;
using WmsApi.Domain;

namespace ApiReport
{
	public class Startup
	{
		private readonly string apiBasePath = "report";

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

			services.AddSignalR();

            // register AutoMapper profiles
            services.AddAutoMapper(typeof(WmspcrContext));

			// register validation
			services.Scan(x =>
				x.FromAssembliesOf(typeof(WmspcrContext))
					.AddClasses(c => c.AssignableToAny(typeof(IValidator<>)))
					.AsImplementedInterfaces()
			);

			services.AddCors(option => option.AddPolicy("cors", policy => policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("*")));
			services.AddControllers().AddNewtonsoftJson();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiReport", Version = "v1" });
				// 获取xml文件名
				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				// 获取xml文件路径
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				//是否显示注释
				c.IncludeXmlComments(xmlPath, true);
			});

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
					c.SwaggerEndpoint($"/{apiBasePath}/v1/swagger.json", $"报表查询 API");
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
