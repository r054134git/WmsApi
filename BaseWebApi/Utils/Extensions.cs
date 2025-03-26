using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WmsApi
{
	public static class Extensions
	{
        public static bool IsValidValue(this string value)
        {
            if (string.IsNullOrEmpty(value) || value == "null")
            {
                return false;
            }

            return true;
        }

        public static string GetUserName(this ClaimsPrincipal claimsPrincipal)
        {
            try
            {
                var claim = claimsPrincipal?.Claims.FirstOrDefault(c => c.Type.ToLower() == "username");
                if (claim == null || string.IsNullOrEmpty(claim.Value))
                {
                    return "unknown";
                }

                return claim.Value;
            }
            catch
            {
                return "unknown";
            }
        }
    }
}
