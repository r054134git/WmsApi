using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class TPlBayBatchCreateModel
    {
        public string Id { get; set; }
        public string BayId { get; set; }
        public string AreaId { get; set; }
        public string StackId { get; set; }
        public int? FromColNo { get; set; }
        public int? ToColNo { get; set; }
        public int? FloorNo { get; set; }
        public int? Count { get; set; }

        public string AreaId2 { get; set; }
        public string StackId2 { get; set; }
        public int? FromColNo2 { get; set; }
        public int? ToColNo2 { get; set; }
        public int? FloorNo2 { get; set; }
        public int? Count2 { get; set; }
    }
}
