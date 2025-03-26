using System;

namespace WmsApi.Contracts
{
    public static class RiGangShitDomain
    {
        /// <summary>
        /// 一课 二课 三课的甲、乙、丙班的账号
        /// </summary>
        private static string[,] AccountNo = new string[3, 3] {
            { "R008229", "R005016", "R037825" } ,
            { "R039355", "R030276", "R013163" },
            { "R011455", "R030958", "R037684" }};


        /// <summary>
        /// "白", "夜"
        /// </summary>
        private static string[] ShiftDay = new string[2] { "白", "夜" };

        /// <summary>
        /// "甲", "乙","丙"
        /// </summary>
        private static string[] ShiftBussiness = new string[3] { "甲", "乙", "丙" };

        /// <summary>
        /// 班组的12小时制排序 1代表上班  0代表休班
        /// </summary>
        private static int[] SeriesShift = new int[] { 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0 };


        private static DateTime dtStartJia = new DateTime(2022, 7, 30, 8, 0, 0);
        private static DateTime dtStartYi = new DateTime(2022, 7, 26, 8, 0, 0);
        private static DateTime dtStartBing = new DateTime(2022, 7, 28, 8, 0, 0);

        /// <summary>
        /// 根据库区和时间得到排班的班长工号
        /// </summary>
        /// <param name="bayCode"></param>
        /// <param name="dtNow"></param>
        /// <returns></returns>
        public static (bool, string) GetAccountNoByBayCode(string bayCode, DateTime dtNow)
        {
            var partIndex = GetPartByBayCode(bayCode);
            if (partIndex == 3)
            {
                return (false, $"获取账号失败，{bayCode}错误");
            }
            //var shiftDay = GetCurrentShiftDay(dtNow);//当前是 "白"  /  "夜"
            var totalHoursFromStart = GetTotalHoursByShiftBussiness(dtNow);
            for (int indexShift = 0; indexShift < 3; indexShift++)
            {
                var index = (totalHoursFromStart[indexShift] / 12) % 12;
                if (SeriesShift[index] == 1)
                {
                    return (true, AccountNo[partIndex, indexShift]);
                    break;
                }
            }
            return (false, "");
        }

        /// <summary>
        /// 根据库区和时间得到班次
        /// </summary>
        /// <param name="bayCode"></param>
        /// <param name="dtNow"></param>
        /// <returns></returns>
        public static string GetAccountNoByBc(string bayCode, DateTime dtNow)
        {
            var partIndex = GetPartByBayCode(bayCode);
            if (partIndex == 3)
            {
                return  $"获取账号失败，{bayCode}错误";
            }
            var totalHoursFromStart = GetTotalHoursByShiftBussiness(dtNow);
            for (int indexShift = 0; indexShift < 3; indexShift++)
            {
                var index = (totalHoursFromStart[indexShift] / 12) % 12;
                if (SeriesShift[index] == 1)
                {
                    return ShiftBussiness[indexShift];
                }
            }
            return "";
        }


        /// <summary>
        /// 获取业务课 1 2 3
        /// </summary>
        /// <param name="bayCode"></param>
        /// <returns></returns>
        private static int GetPartByBayCode(string bayCode)
        {
            if (bayCode == "16" || bayCode == "17" || bayCode == "18" || bayCode == "19")
            {
                return 0;
            }
            if (bayCode == "21" || bayCode == "22" || bayCode == "23" || bayCode == "24")
            {
                return 1;
            }
            if (bayCode == "25" || bayCode == "26" || bayCode == "27")
            {
                return 2;
            }
            return 3;
        }

        /// <summary>
        /// 获取当前的班组是白班/夜班
        /// </summary>
        /// <returns></returns>
        private static string GetCurrentShiftDay(DateTime dtNow)
        {
            if (dtNow.Hour >= 8 && dtNow.Hour < 20)
            {
                return ShiftDay[0];
            }
            else
            {
                return ShiftDay[1];
            }
        }

        private static int[] GetTotalHoursByShiftBussiness(DateTime time)
        {
            int[] totalHours = new int[3];
            totalHours[0] = Convert.ToInt32(Math.Floor((time - dtStartJia).TotalHours));
            totalHours[1] = Convert.ToInt32(Math.Floor((time - dtStartYi).TotalHours));
            totalHours[2] = Convert.ToInt32(Math.Floor((time - dtStartBing).TotalHours));

            return totalHours;
        }

    }
}
