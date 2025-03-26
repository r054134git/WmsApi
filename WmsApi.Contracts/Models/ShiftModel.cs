using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class ShiftModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public int matSum { get; set; }
        public int lockMatSum { get; set; }
        public int cmdMatSum { get; set; }
        public int outMat { get; set; }
        public int ZMat { get; set; }

        public string time { get; set; }

    }
}
