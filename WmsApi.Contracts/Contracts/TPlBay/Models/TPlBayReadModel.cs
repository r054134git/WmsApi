using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 跨吊运计划表
    /// </summary>
    public partial class TPlBayReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'PlanNo'.
        /// '计划编号'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanNo'.
        /// </value>
        public string PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialId'.
        /// '物料id'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialId'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanTypeId'.
        /// '吊运类型'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanTypeId'.
        /// </value>
        public string PlanTypeId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanTypeName'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PlanTypeName'.
        /// </value>
        public string PlanTypeName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '跨'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayName'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BayName'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SortIndex'.
        /// '计划次序'.
        /// </summary>
        /// <value>
        /// The property value for 'SortIndex'.
        /// </value>
        public int SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayTransferPlanId'.
        /// '库内吊运计划ID'.
        /// </summary>
        /// <value>
        /// The property value for 'BayTransferPlanId'.
        /// </value>
        public string BayTransferPlanId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransferStep'.
        /// '库间转运步骤，0：无意义，1：装车，2：转运，3：卸车'.
        /// </summary>
        /// <value>
        /// The property value for 'TransferStep'.
        /// </value>
        public int TransferStep { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanState'.
        /// '0:未处理 1：已排库位   2：预排任务  3：已生成任务'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanState'.
        /// </value>
        public int PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ExecState'.
        /// '执行状态 0：未执行 1：正在执行 2：已完成'.
        /// </summary>
        /// <value>
        /// The property value for 'ExecState'.
        /// </value>
        public int ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ResolveState'.
        /// '分解状态，0：未分解 1：已分解'.
        /// </summary>
        /// <value>
        /// The property value for 'ResolveState'.
        /// </value>
        public int ResolveState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PriorityOperator'.
        /// '用户优先级'.
        /// </summary>
        /// <value>
        /// The property value for 'PriorityOperator'.
        /// </value>
        public int PriorityOperator { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadLocationId'.
        /// '拾取库位id'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadLocationId'.
        /// </value>
        public string LoadLocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadLocationName'.
        /// '拾取库位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadLocationName'.
        /// </value>
        public string LoadLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadLocationId'.
        /// '释放库位id'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadLocationId'.
        /// </value>
        public string UnloadLocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadLocationName'.
        /// '释放库位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadLocationName'.
        /// </value>
        public string UnloadLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsTruckLoadFixed'.
        /// '装车是否次序固定，0：不固定，1：固定'.
        /// </summary>
        /// <value>
        /// The property value for 'IsTruckLoadFixed'.
        /// </value>
        public int? IsTruckLoadFixed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckNo'.
        /// '装车车号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckNo'.
        /// </value>
        public string TruckNo { get; set; }

        #endregion

    }
}
