using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 区域范围规则表
    /// </summary>
    public partial class TRlRegionRangeReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Region'.
        /// '区'.
        /// </summary>
        /// <value>
        /// The property value for 'Region'.
        /// </value>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RowMin'.
        /// '最小行'.
        /// </summary>
        /// <value>
        /// The property value for 'RowMin'.
        /// </value>
        public int? RowMin { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RowMax'.
        /// '最大行'.
        /// </summary>
        /// <value>
        /// The property value for 'RowMax'.
        /// </value>
        public int? RowMax { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ColMax'.
        /// '最大列'.
        /// </summary>
        /// <value>
        /// The property value for 'ColMax'.
        /// </value>
        public int? ColMax { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ColMin'.
        /// '最小列'.
        /// </summary>
        /// <value>
        /// The property value for 'ColMin'.
        /// </value>
        public int? ColMin { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SortIndex'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SortIndex'.
        /// </value>
        public int? SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RowOrderType'.
        /// '1:升序排列 2：降序排列'.
        /// </summary>
        /// <value>
        /// The property value for 'RowOrderType'.
        /// </value>
        public int? RowOrderType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ColOrderType'.
        /// '1:升序排列 2：降序排列'.
        /// </summary>
        /// <value>
        /// The property value for 'ColOrderType'.
        /// </value>
        public int? ColOrderType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsFillFirst'.
        /// '优先填满'.
        /// </summary>
        /// <value>
        /// The property value for 'IsFillFirst'.
        /// </value>
        public int? IsFillFirst { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StationNo'.
        /// '吊装位编号'.
        /// </summary>
        /// <value>
        /// The property value for 'StationNo'.
        /// </value>
        public int? StationNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AllowL2'.
        /// '允许二层'.
        /// </summary>
        /// <value>
        /// The property value for 'AllowL2'.
        /// </value>
        public int? AllowL2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion
        /// <summary>
        /// 一层鞍座数量
        /// </summary>
        public int CoilPositionCount1 { get; set; }

        /// <summary>
        /// 一层钢卷数量
        /// </summary>
        public int CoilCount1 { get; set; }

        /// <summary>
        /// 二层鞍座数量
        /// </summary>
        public int CoilPositionCount2 { get; set; }

        /// <summary>
        /// 二层钢卷数量
        /// </summary>
        public int CoilCount2 { get; set; }

        public string RegionName { get; set; }
    }
}
