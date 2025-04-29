using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class BayAreaStackColRead
    {
        public string BayId { get; set; }
        public string AreaId { get; set; }
        public string StartStackId { get; set; }
        public string EndStackId { get; set; }
        public string StartColNoId { get; set; }
        public string EndColNoId { get; set; }
        public int PlanCount { get; set; }
       
    }
}
