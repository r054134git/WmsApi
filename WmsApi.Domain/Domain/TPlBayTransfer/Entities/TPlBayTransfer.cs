using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_bay_transfer'.
    /// </summary>
    public partial class TPlBayTransfer
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBayTransfer"/> class.
        /// 库间倒运计划
        /// </summary>
        public TPlBayTransfer()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NO'.
        /// '计划编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NO'.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_ID'.
        /// '物料id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_ID'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// 'JSON格式字符串，物料号/materialNo'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_ID'.
        /// '计划类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_ID'.
        /// </value>
        public string PlanTypeId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME'.
        /// '计划类型名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME'.
        /// </value>
        public string PlanTypeName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_BAY_ID'.
        /// '起点跨'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_BAY_ID'.
        /// </value>
        public string FromBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_BAY_NAME'.
        /// '起点跨'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_BAY_NAME'.
        /// </value>
        public string FromBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_BAY_ID'.
        /// '目标跨'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_BAY_ID'.
        /// </value>
        public string DestBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_BAY_NAME'.
        /// '目标跨'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_BAY_NAME'.
        /// </value>
        public string DestBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANS_TYPE'.
        /// '设备类型 0：无，1：汽车，2：过跨车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANS_TYPE'.
        /// </value>
        public int? TransType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_TYPE_ID'.
        /// '转运工具类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_TYPE_ID'.
        /// </value>
        public string VehicleTypeId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_TYPE_NAME'.
        /// '转运工具类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_TYPE_NAME'.
        /// </value>
        public string VehicleTypeName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_STATE'.
        /// '0:未处理 1：已排库位   2：预排任务  3：已生成任务 4：冻结'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_STATE'.
        /// </value>
        public int PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RESOLVE_STATE'.
        /// '分解状态，0：未分解 1：已分解'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RESOLVE_STATE'.
        /// </value>
        public int ResolveState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EXEC_STATE'.
        /// '执行状态   0：未执行 1：正在执行装车 2：已完成装车，3：正在执行转运，4：已完成转运，5：正在执行卸车，6：已完成卸车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EXEC_STATE'.
        /// </value>
        public int ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CROSS_BAY_TASK_ID'.
        /// '过跨任务id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CROSS_BAY_TASK_ID'.
        /// </value>
        public string CrossBayTaskId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRIORITY_OPERATOR'.
        /// '优先级'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRIORITY_OPERATOR'.
        /// </value>
        public int? PriorityOperator { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ENABLE'.
        /// '是否可用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ENABLE'.
        /// </value>
        public int IsEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// '创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_USER'.
        /// '创建人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_USER'.
        /// </value>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_TIME'.
        /// '更新时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_TIME'.
        /// </value>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_USER'.
        /// '更新人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_USER'.
        /// </value>
        public string UpdateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMARK'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMARK'.
        /// </value>
        public string Remark { get; set; }

        #endregion

        #region Generated Relationships
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhBay" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhBay" />.
        /// </value>
        /// <seealso cref="DestBayId" />
        public virtual TWhBay DestBayTWhBay { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhBay" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhBay" />.
        /// </value>
        /// <seealso cref="FromBayId" />
        public virtual TWhBay FromBayTWhBay { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhPlanType" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhPlanType" />.
        /// </value>
        /// <seealso cref="PlanTypeId" />
        public virtual TWhPlanType PlanTypeTWhPlanType { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TEqCrossVehicle" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TEqCrossVehicle" />.
        /// </value>
        /// <seealso cref="VehicleTypeId" />
        public virtual TEqCrossVehicle VehicleTypeTEqCrossVehicle { get; set; }

        #endregion

    }
}
