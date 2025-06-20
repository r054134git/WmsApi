using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 生产计划明细
    /// </summary>
    public partial class TPlProductionDetailReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'ProductionNo'.
        /// '生产计划号'.
        /// </summary>
        /// <value>
        /// The property value for 'ProductionNo'.
        /// </value>
        public string ProductionNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialId'.
        /// '材料ID'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialId'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '材料号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductionCoilSeq'.
        /// '生产计划钢卷序号'.
        /// </summary>
        /// <value>
        /// The property value for 'ProductionCoilSeq'.
        /// </value>
        public int? ProductionCoilSeq { get; set; }

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
