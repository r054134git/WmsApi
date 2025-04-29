using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts
{
    public class ReportInventory
    {
        public string Id { get; set; }
        public string OwnerBussinessName { get; set; }//库别
        public string BayCode { get; set; }
        public string PlanNo { get; set; }
        public int ScanCount { get; set; } //扫描个数
        public int WmsCount { get; set; }//系统在库个数
        public int ScanInWmsCount { get; set; }//扫描在库个数
        public int ScanNotInWmsCount { get; set; }//扫描不在库个数
        public int WmsNotInScanCount { get; set; }//在库未扫描个数
        public string SystemComment { get; set; } //系统分析
        public List<ReportInventoryDetail> Details { get; set; } = new List<ReportInventoryDetail>();

    }
    public class ReportInventoryDetail
    {
        public string MaterialNo { get; set; }
        public string BundleNo { get; set; } //捆包号
        public int? IsScan { get; set; }
        public int? IsWms { get; set; }
        public string SystemComment { get; set; } //系统分析
    }
}
