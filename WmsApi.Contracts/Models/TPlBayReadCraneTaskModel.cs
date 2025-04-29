using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public partial class TPlBayReadCraneTaskModel : TPlBayReadModel
    {
        public List<TPlCraneTaskReadModel> plCraneTaskList { get; set; }
    }

}
