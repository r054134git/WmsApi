using Microsoft.AspNetCore.Mvc.Filters;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace WmsApi
{
    public class TokenActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var test = context.HttpContext.Request.Path;
            var header = context.HttpContext.Request.Headers;
            if (header.TryGetValue("Authorization", out var bearers) && bearers.Any())
            {
                string bearer = bearers.FirstOrDefault();
                if (string.IsNullOrEmpty(bearer) || !bearer.Contains("Bearer"))
                {
                    return;
                }
                string[] jwt = bearer.Split(' ');
                var tokenObj = new JwtSecurityToken(jwt[1]);

                var claimsIdentity = new ClaimsIdentity(tokenObj.Claims);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                context.HttpContext.User = claimsPrincipal;
            }
        }
    }
}
