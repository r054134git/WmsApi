using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class MaterialVirtualModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int VirtualCount { get; set; }
    }
}
