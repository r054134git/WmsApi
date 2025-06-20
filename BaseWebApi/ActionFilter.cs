using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WmsApi
{
	/// <summary>
	/// 方法过滤器
	/// </summary>
	public class ActionFilter : IActionFilter
	{
		/// <summary>
		/// 监控日志
		/// </summary>
		private ILogger _logger { get; set; }

		public ActionFilter(ILogger<ActionFilter> logger)
		{
			_logger = logger;
		}


		/// <summary>
		/// 创建请求日志文本
		/// </summary>
		/// <param name="method">请求方法</param>
		/// <param name="controllerName">控制器名称</param>
		/// <param name="actionName">方法名称</param>
		/// <param name="actionArgs">方法参数</param>
		/// <returns></returns>
		private static string CreateRequestLogText(string user, string method, string controllerName, string actionName, IDictionary<string, object> actionArgs)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"收到用户[{user}]请求[{method}]/{controllerName}/{actionName}，参数：");
			if (actionArgs.Count > 0)
			{
				foreach (var p in actionArgs)
				{
					sb.AppendLine($"    " + p.Key + "：" + JsonConvert.SerializeObject(p.Value));
				}
			}
			else
			{
				sb.AppendLine("    无");
			}
			return sb.ToString();
		}

		/// <summary>
		/// 创建响应日志文本
		/// </summary>
		/// <param name="method">请求方法</param>
		/// <param name="controllerName">控制器名称</param>
		/// <param name="actionName">方法名称</param>
		/// <param name="result">执行结果</param>
		/// <returns></returns>
		private static string CreateResponseLogText(string method, string controllerName, string actionName, object result)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"完成请求[{method}]/{controllerName}/{actionName}，结果：");
			if (result != null)
			{
				sb.AppendLine("    " + Newtonsoft.Json.JsonConvert.SerializeObject(result));
			}
			else
			{
				sb.AppendLine("    无");
			}
			return sb.ToString();
		}

		public static string GetUserToken(ActionExecutingContext context)
		{
			var header = context.HttpContext.Request.Headers;
			if (header.TryGetValue("Authorization", out var bearers) && bearers.Any())
			{
				string bearer = bearers.FirstOrDefault();
				if (string.IsNullOrEmpty(bearer) || !bearer.Contains("Bearer"))
				{
					return "Unknown";
				}
				string[] jwt = bearer.Split(' ');
				if (jwt.Length > 1)
				{
					var tokenObj = new JwtSecurityToken(jwt[1]);
					var claimsIdentity = new ClaimsIdentity(tokenObj.Claims);
					var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
					return claimsPrincipal.GetUserName();
				}
				return "Unknown";
			}
			return "Unknown";
		}

		/// <summary>
		/// 方法执行前
		/// </summary>
		/// <param name="context"></param>
		public void OnActionExecuting(ActionExecutingContext context)
		{
			if (_logger != null)
			{
				// 记录请求参数日志
				var desc = context.ActionDescriptor as ControllerActionDescriptor;
				if (desc != null)
				{
					var logText = CreateRequestLogText(
						GetUserToken(context),
						context.HttpContext.Request.Method,
						desc.ControllerName,
						desc.ActionName,
						context.ActionArguments);
					_logger.LogDebug(logText);
				}
			}
		}

		/// <summary>
		/// 方法执行后
		/// </summary>
		/// <param name="context"></param>
		public void OnActionExecuted(ActionExecutedContext context)
		{
			if (context.Exception != null)
			{
				// 记录异常日志
				if (_logger != null)
				{
					_logger.LogError(context.Exception, context.Exception.Message);
				}
			}

			if (_logger != null)
			{
				// 记录请求结果日志
				ControllerActionDescriptor desc = context.ActionDescriptor as ControllerActionDescriptor;
				if (desc != null)
				{
					ObjectResult rst = context.Result as ObjectResult;
					var rstValue = rst?.Value;
					var logText = CreateResponseLogText(
						context.HttpContext.Request.Method,
						desc.ControllerName,
						desc.ActionName,
						rstValue);
					_logger.LogDebug(logText);
				}
			}
		}
	}
}