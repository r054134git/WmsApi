using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TEqCraneWeightCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CraneId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CraneId'.
        /// </value>
        public string CraneId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MeterUpperLimit'.
        /// '仪表读数上限'.
        /// </summary>
        /// <value>
        /// The property value for 'MeterUpperLimit'.
        /// </value>
        public decimal MeterUpperLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MeterLowerLimit'.
        /// '仪表读数下限'.
        /// </summary>
        /// <value>
        /// The property value for 'MeterLowerLimit'.
        /// </value>
        public decimal MeterLowerLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WeightUpperLimit'.
        /// '重量上限'.
        /// </summary>
        /// <value>
        /// The property value for 'WeightUpperLimit'.
        /// </value>
        public decimal WeightUpperLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WeightLowerLimit'.
        /// '重量下限'.
        /// </summary>
        /// <value>
        /// The property value for 'WeightLowerLimit'.
        /// </value>
        public decimal WeightLowerLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion

    }
}
