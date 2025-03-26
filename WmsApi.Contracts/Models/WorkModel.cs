using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{

    public class WorkModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public long Mode3Time { get; set; }
        public long Mode1Time { get; set; }

        public double Mode1TimePercent { get; set; }

    }
}
