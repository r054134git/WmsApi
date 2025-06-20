using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class LocationPercent
    {
        public string id { get; set; }
        public string name { get; set; }
        public int oneLoSum { get; set; }
        public int oneNoSum { get; set; }
        public int twoLoSum { get; set; }
        public int twoNoSum { get; set; }
        public Double oneFloorPer { get; set; }
        public Double twoFloorPer { get; set; }
        public Double allFloorPer { get; set; }
    }
}
