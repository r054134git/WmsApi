using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 吊运计划任务类型
    /// </summary>
    public partial class TWhPlanTypeCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '吊运任务名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SimpleName'.
        /// '简称'.
        /// </summary>
        /// <value>
        /// The property value for 'SimpleName'.
        /// </value>
        public string SimpleName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ClassLabel'.
        /// '分类标签'.
        /// </summary>
        /// <value>
        /// The property value for 'ClassLabel'.
        /// </value>
        public string ClassLabel { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromLocationType'.
        /// '起点库位存储类型'.
        /// </summary>
        /// <value>
        /// The property value for 'FromLocationType'.
        /// </value>
        public int FromLocationType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestLocationType'.
        /// '目标库位存储类型'.
        /// </summary>
        /// <value>
        /// The property value for 'DestLocationType'.
        /// </value>
        public int DestLocationType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromBayId'.
        /// '源跨区id'.
        /// </summary>
        /// <value>
        /// The property value for 'FromBayId'.
        /// </value>
        public string FromBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestBayId'.
        /// '目的跨区id'.
        /// </summary>
        /// <value>
        /// The property value for 'DestBayId'.
        /// </value>
        public string DestBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InOutType'.
        /// '计划类型 1:入库，2:出库，3:倒垛, 4:退库'.
        /// </summary>
        /// <value>
        /// The property value for 'InOutType'.
        /// </value>
        public int InOutType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsCrossBay'.
        /// '0:不过跨 1：过跨'.
        /// </summary>
        /// <value>
        /// The property value for 'IsCrossBay'.
        /// </value>
        public int IsCrossBay { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransType'.
        /// '过跨设备类型 0：无，1：汽车，2：过跨车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value for 'TransType'.
        /// </value>
        public int TransType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackGroundColor'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackGroundColor'.
        /// </value>
        public string BackGroundColor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SortSeq'.
        /// '排序序号'.
        /// </summary>
        /// <value>
        /// The property value for 'SortSeq'.
        /// </value>
        public int SortSeq { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DefaultPriority'.
        /// '默认优先级'.
        /// </summary>
        /// <value>
        /// The property value for 'DefaultPriority'.
        /// </value>
        public int DefaultPriority { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

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
