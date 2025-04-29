using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class LocationStartEndRead
    {
        public string Id { get; set; }
        public string MaterialNo { get; set; }
        public int? Weight { get; set; }
        public string LoadLocationName { get; set; }
        public string UnloadLocationName { get; set; }
        public decimal? Diameter { get; set; }
        public decimal? InnerDiameter { get; set; }

    }
}
