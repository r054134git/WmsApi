using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGateway
{
	public class Startup
	{
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
		{
            //AddAuth(services);
            services.AddReverseProxy().LoadFromConfig(Configuration.GetSection("ReverseProxy"));
		}

        void AddAuth(IServiceCollection services)
        {
            //读取配置文件
            var audienceConfig = Configuration.GetSection("Audience");
            var symmetricKeyAsBase64 = audienceConfig["Secret"];
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,
                ValidateIssuer = true,
                ValidIssuer = audienceConfig["Issuer"],
                ValidateAudience = true,
                ValidAudience = audienceConfig["Audience"],
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                RequireExpirationTime = true,

            };
            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            //这个集合模拟用户权限表,可从数据库中查询出来
            //var permission = new List<Permission> {
            //                  new Permission {  Url="/webapi01/test1", Name="admin"},
            //                  new Permission {  Url="/webapi01/test3", Name="admin"},
            //                  new Permission {  Url="/webapi02/test2", Name="admin"},
            //                  new Permission {  Url="/webapi02/test4", Name="admin"},

            //              };
            ////如果第三个参数，是ClaimTypes.Role，上面集合的每个元素的Name为角色名称，如果ClaimTypes.Name，即上面集合的每个元素的Name为用户名
            //var permissionRequirement = new PermissionRequirement(
            //    "/api/denied", permission,
            //    ClaimTypes.Role,
            //    audienceConfig["Issuer"],
            //    audienceConfig["Audience"],
            //    signingCredentials,
            //    expiration: TimeSpan.FromSeconds(1000000)//设置Token过期时间
            //    );

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("Permission", policy => policy.AddRequirements(permissionRequirement));
            //}).
            //AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
            //{

            //    //不使用https
            //    o.RequireHttpsMetadata = false;
            //    o.TokenValidationParameters = tokenValidationParameters;

            //    o.Events = new JwtBearerEvents
            //    {
            //        OnTokenValidated = context =>
            //        {
            //            if (context.Request.Path.Value.ToString() == "/api/logout")
            //            {
            //                var token = ((context as TokenValidatedContext).SecurityToken as JwtSecurityToken).RawData;
            //            }
            //            return Task.CompletedTask;
            //        }
            //    };
            //});
            ////注入授权Handler
            //services.AddSingleton<IAuthorizationHandler, PermissionHandler>();
            //services.AddSingleton(permissionRequirement);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			//if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new EmbeddedFileProvider(
                                    assembly: typeof(Startup).Assembly,
                                    baseNamespace: "ApiGateway.wwwroot"),
            });

            app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
                //endpoints.MapGet("/", async context =>
                //{
                //	await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapGet("/", async http => { http.Response.Redirect("/index.html"); });
                endpoints.MapReverseProxy();
            });
		}
	}
}
