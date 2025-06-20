using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class BLModel
    {
        public string id { get; set; }
        public string name { get; set; }

        public DateTime strTime { get; set; }
        public DateTime endTime { get; set; }

        public int inputZ { get; set; }
        public int inputR { get; set; }
        public int outZ { get; set; }
        public int outR { get; set; }
        public int outRsys { get; set; }
        
        public int ddZ { get; set; }
        public int ddR { get; set; }
        public int ddGK { get; set; }
        public int ddKJ { get; set; }
        public double inputBl { get; set; }
        public double outBl { get; set; }

    }
}
