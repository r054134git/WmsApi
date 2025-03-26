using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class HoldPickModel
    {
        public int Count { get; set; }
        public string LocationName { get; set; }
        public string MaterialNo { get; set; }
        public int Weight { get; set; }
        public string Width { get; set; }
        public string VehicleNo { get; set; }
        public int? PickState { get; set; }
        public string ColorDemand { get; set; }//刷色
        public string PackingTypeCode { get; set; }//包装代码
        public string MainTruckLoadingNo { get; set; } //主装车单
        public string MatDisposeCode { get; set; }//物料处置代码
        public string SteelGrade { get; set; }//类别
        public decimal Thick { get; set; } //厚度
        public string MatDisposeCodeDesc
        {
            get
            {
                switch (MatDisposeCode)
                {
                    case "1":
                        return "合格品";
                    case "2":
                        return "再处理";
                    case "3":
                        return "";
                    case "4":
                        return "次品";
                    case "5":
                        return "废品(外卖)";
                    case "6":
                        return "废品";
                    case "8":
                        return "重度废品";
                    case "H":
                        return "暂留";
                }
                return "未知";
            }
        }
    }
}
