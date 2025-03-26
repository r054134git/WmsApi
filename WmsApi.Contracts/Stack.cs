using System;
using System.Collections.Generic;
using System.Text;
using WmsApi.Contracts.Models;

namespace WmsApi.Contracts
{
    public class Stack
    {
        public int CoilPositionCount1 { get; set; }

        public int CoilCount1 { get; set; }

        public int CoilPositionCount2 { get; set; }

        public int CoilCount2 { get; set; }

        public int StackNo { get; set; }

        public string RegionNo { get; set; }

        public List<TTrLocationMaterialReadModel> Items { get; set; } = new List<TTrLocationMaterialReadModel>();
    }
}
