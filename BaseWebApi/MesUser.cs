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
    /// Mes用户
    /// </summary>
    public class MesUser
    {

        //一课账号信息
        public static Dictionary<string, string> UsersPart1 = new Dictionary<string, string>()
        {
            {"甲班", "R008229" },
            {"乙班", "R005016" },
            {"丙班", "R037825" }
        };
        //二课账号信息
        public static Dictionary<string, string> UsersPart2 = new Dictionary<string, string>()
        {
            {"甲班", "R039355" },
            {"乙班", "R030276" },
            {"丙班", "R013163" }
        };
        //三课账号信息
        public static Dictionary<string, string> UsersPart3 = new Dictionary<string, string>()
        {
            {"甲班", "R011455" },
            {"乙班", "R030958" },
            {"丙班", "R037684" }
        };

        public static string GetUserName(string house)
        {
            if (house == "P5")
            {
                string team = GetTeam(DateTime.Now);
                if (UsersPart1.TryGetValue(team, out string userName))
                {
                    return userName;
                }
            }
            if (house == "P6")
            {
                string team = GetTeam(DateTime.Now);
                if (UsersPart2.TryGetValue(team, out string userName))
                {
                    return userName;
                }
            }
            if (house == "P8")
            {
                string team = GetTeam(DateTime.Now);
                if (UsersPart3.TryGetValue(team, out string userName))
                {
                    return userName;
                }
            }
            return "";
        }

        public static string GetShift(DateTime dateTime)
        {
            if (dateTime.Hour >= 20 || dateTime.Hour < 8)
            {
                return "夜班";
            }
            else
            {
                return "白班";
            }
        }

        public static string GetTeam(DateTime currentDate)
        {
            int cycleDays = 6;
            DateTime startDate = new DateTime(2022, 7, 30);

            int cycleCount = (currentDate - startDate).Days / cycleDays;
            var date = currentDate.AddDays(-cycleCount * 6);


            if (date >= new DateTime(2022, 7, 30, 8, 0, 0) &&
                date < new DateTime(2022, 7, 30, 20, 0, 0))
            {
                return "甲班";
            }
            else if (date >= new DateTime(2022, 7, 30, 20, 0, 0) &&
                    date < new DateTime(2022, 7, 31, 8, 0, 0))
            {
                return "丙班";
            }
            else if (date >= new DateTime(2022, 7, 31, 8, 0, 0) &&
                    date < new DateTime(2022, 7, 31, 20, 0, 0))
            {
                return "甲班";
            }
            else if (date >= new DateTime(2022, 7, 31, 20, 0, 0) &&
                    date < new DateTime(2022, 8, 1, 8, 0, 0))
            {
                return "丙班";
            }
            else if (date >= new DateTime(2022, 8, 1, 8, 0, 0) &&
                    date < new DateTime(2022, 8, 1, 20, 0, 0))
            {
                return "乙班";
            }
            else if (date >= new DateTime(2022, 8, 1, 20, 0, 0) &&
                    date < new DateTime(2022, 8, 2, 8, 0, 0))
            {
                return "甲班";
            }
            else if (date >= new DateTime(2022, 8, 2, 8, 0, 0) &&
                    date < new DateTime(2022, 8, 2, 20, 0, 0))
            {
                return "乙班";
            }
            else if (date >= new DateTime(2022, 8, 2, 20, 0, 0) &&
                    date < new DateTime(2022, 8, 3, 8, 0, 0))
            {
                return "甲班";
            }
            else if (date >= new DateTime(2022, 8, 3, 8, 0, 0) &&
                    date < new DateTime(2022, 8, 3, 20, 0, 0))
            {
                return "丙班";
            }
            else if (date >= new DateTime(2022, 8, 3, 20, 0, 0) &&
                    date < new DateTime(2022, 8, 4, 8, 0, 0))
            {
                return "乙班";
            }
            else if (date >= new DateTime(2022, 8, 4, 8, 0, 0) &&
                    date < new DateTime(2022, 8, 4, 20, 0, 0))
            {
                return "丙班";
            }
            else if (date >= new DateTime(2022, 8, 4, 20, 0, 0) &&
                    date < new DateTime(2022, 8, 5, 8, 0, 0))
            {
                return "乙班";
            }
            return "未知班组";
        }
    }
}