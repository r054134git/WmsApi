using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TPlFinishLineReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'LineNo'.
        /// '产线编号(机组号)'.
        /// </summary>
        /// <value>
        /// The property value for 'LineNo'.
        /// </value>
        public string LineNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanNo'.
        /// '计划编号'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanNo'.
        /// </value>
        public string PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanState'.
        /// '计划状态 N :上料  D:取消上料'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanState'.
        /// </value>
        public string PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanType'.
        /// '计划类型 (CSL：横切，RCL：纵切，ZQL：重卷)'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanType'.
        /// </value>
        public string PlanType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialSortIndex'.
        /// '物料顺序'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialSortIndex'.
        /// </value>
        public int? MaterialSortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion

        public bool IsCheck { get; set; }
    }
}
