using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库位规则表
    /// </summary>
    public partial class TRlTransferPrewiredUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'StowageType'.
        /// '配载类型 1=内贸 2=外贸 3=水汽联运'.
        /// </summary>
        /// <value>
        /// The property value for 'StowageType'.
        /// </value>
        public int? StowageType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsDistributionShip'.
        /// '是否配船 0=无 1=配船 2=非配船'.
        /// </summary>
        /// <value>
        /// The property value for 'IsDistributionShip'.
        /// </value>
        public int? IsDistributionShip { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsSpec'.
        /// '是否限制规格 0=不限 1=限制'.
        /// </summary>
        /// <value>
        /// The property value for 'IsSpec'.
        /// </value>
        public int? IsSpec { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PortLotNumber'.
        /// '支持的港口批号 数量'.
        /// </summary>
        /// <value>
        /// The property value for 'PortLotNumber'.
        /// </value>
        public int? PortLotNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderNo'.
        /// '排序号'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderNo'.
        /// </value>
        public int? OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WeightLimit'.
        /// '允许配载的最大重量'.
        /// </summary>
        /// <value>
        /// The property value for 'WeightLimit'.
        /// </value>
        public int? WeightLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NumberLimit'.
        /// '允许配载的最大件数'.
        /// </summary>
        /// <value>
        /// The property value for 'NumberLimit'.
        /// </value>
        public int? NumberLimit { get; set; }

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
