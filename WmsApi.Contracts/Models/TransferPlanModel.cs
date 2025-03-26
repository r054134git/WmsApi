using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class TransferPlanModel
    {
        public int Count { get; set; }
        public string MaterialNo { get; set; }
        public string FromBay { get; set; }
        public string DestBay { get; set; }
    }
}
