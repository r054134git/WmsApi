using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库间倒运计划
    /// </summary>
    public partial class TPlBayTransferReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'No'.
        /// '计划编号'.
        /// </summary>
        /// <value>
        /// The property value for 'No'.
        /// </value>
        public string No { get; set; }

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
        /// 'JSON格式字符串，物料号/materialNo'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanTypeId'.
        /// '计划类型'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanTypeId'.
        /// </value>
        public string PlanTypeId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanTypeName'.
        /// '计划类型名称'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanTypeName'.
        /// </value>
        public string PlanTypeName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromBayId'.
        /// '起点跨'.
        /// </summary>
        /// <value>
        /// The property value for 'FromBayId'.
        /// </value>
        public string FromBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromBayName'.
        /// '起点跨'.
        /// </summary>
        /// <value>
        /// The property value for 'FromBayName'.
        /// </value>
        public string FromBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestBayId'.
        /// '目标跨'.
        /// </summary>
        /// <value>
        /// The property value for 'DestBayId'.
        /// </value>
        public string DestBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestBayName'.
        /// '目标跨'.
        /// </summary>
        /// <value>
        /// The property value for 'DestBayName'.
        /// </value>
        public string DestBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransType'.
        /// '设备类型 0：无，1：汽车，2：过跨车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value for 'TransType'.
        /// </value>
        public int? TransType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VehicleTypeId'.
        /// '转运工具类型'.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleTypeId'.
        /// </value>
        public string VehicleTypeId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VehicleTypeName'.
        /// '转运工具类型'.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleTypeName'.
        /// </value>
        public string VehicleTypeName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanState'.
        /// '0:未处理 1：已排库位   2：预排任务  3：已生成任务 4：冻结'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanState'.
        /// </value>
        public int PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ResolveState'.
        /// '分解状态，0：未分解 1：已分解'.
        /// </summary>
        /// <value>
        /// The property value for 'ResolveState'.
        /// </value>
        public int ResolveState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ExecState'.
        /// '执行状态   0：未执行 1：正在执行装车 2：已完成装车，3：正在执行转运，4：已完成转运，5：正在执行卸车，6：已完成卸车'.
        /// </summary>
        /// <value>
        /// The property value for 'ExecState'.
        /// </value>
        public int ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CrossBayTaskId'.
        /// '过跨任务id'.
        /// </summary>
        /// <value>
        /// The property value for 'CrossBayTaskId'.
        /// </value>
        public string CrossBayTaskId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PriorityOperator'.
        /// '优先级'.
        /// </summary>
        /// <value>
        /// The property value for 'PriorityOperator'.
        /// </value>
        public int? PriorityOperator { get; set; }

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
