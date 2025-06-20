using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class VMaterialEventReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '库区编码'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CraneName'.
        /// '行车名称'.
        /// </summary>
        /// <value>
        /// The property value for 'CraneName'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialId'.
        /// '材料id'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialId'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Dt'.
        /// '时间'.
        /// </summary>
        /// <value>
        /// The property value for 'Dt'.
        /// </value>
        public DateTime Dt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '材料号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNoOld'.
        /// '材料号变更前的钢卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNoOld'.
        /// </value>
        public string MaterialNoOld { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OperationType'.
        /// '人工/自动'.
        /// </summary>
        /// <value>
        /// The property value for 'OperationType'.
        /// </value>
        public string OperationType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ContentType'.
        /// '生产计划/入库计划/入库/倒库计划/倒库/出库计划/出库/退库计划/退库'.
        /// </summary>
        /// <value>
        /// The property value for 'ContentType'.
        /// </value>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromLocationName'.
        /// '起点库位'.
        /// </summary>
        /// <value>
        /// The property value for 'FromLocationName'.
        /// </value>
        public string FromLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ToLocationName'.
        /// '终点库位'.
        /// </summary>
        /// <value>
        /// The property value for 'ToLocationName'.
        /// </value>
        public string ToLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Description'.
        /// '描述'.
        /// </summary>
        /// <value>
        /// The property value for 'Description'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromPosition'.
        /// '起点坐标'.
        /// </summary>
        /// <value>
        /// The property value for 'FromPosition'.
        /// </value>
        public string FromPosition { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ToPosition'.
        /// '终点坐标'.
        /// </summary>
        /// <value>
        /// The property value for 'ToPosition'.
        /// </value>
        public string ToPosition { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Result'.
        /// '成功/失败/撤销'.
        /// </summary>
        /// <value>
        /// The property value for 'Result'.
        /// </value>
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Weight'.
        /// '产品卷重kg'.
        /// </summary>
        /// <value>
        /// The property value for 'Weight'.
        /// </value>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatDirection'.
        /// '材料去向(BMWM01 流向 U127)'.
        /// </summary>
        /// <value>
        /// The property value for 'MatDirection'.
        /// </value>
        public string MatDirection { get; set; }

        #endregion

    }
}
