using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_bay'.
    /// </summary>
    public partial class TPlBay
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBay"/> class.
        /// 跨吊运计划表
        /// </summary>
        public TPlBay()
        {
            #region Generated Constructor
            OwnerTPlCraneTasks = new HashSet<TPlCraneTask>();
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
        /// Gets or sets the property value representing column 'PLAN_NO'.
        /// '计划编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_NO'.
        /// </value>
        public string PlanNo { get; set; }

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
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_ID'.
        /// '吊运类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_ID'.
        /// </value>
        public string PlanTypeId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME'.
        /// </value>
        public string PlanTypeName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '跨'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_NAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_NAME'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORT_INDEX'.
        /// '计划次序'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT_INDEX'.
        /// </value>
        public int SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_TRANSFER_PLAN_ID'.
        /// '库内吊运计划ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_TRANSFER_PLAN_ID'.
        /// </value>
        public string BayTransferPlanId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANSFER_STEP'.
        /// '库间转运步骤，0：无意义，1：装车，2：转运，3：卸车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANSFER_STEP'.
        /// </value>
        public int TransferStep { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_STATE'.
        /// '0:未处理 1：已排库位   2：预排任务  3：已生成任务'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_STATE'.
        /// </value>
        public int PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EXEC_STATE'.
        /// '执行状态 0：未执行 1：正在执行 2：已完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EXEC_STATE'.
        /// </value>
        public int ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RESOLVE_STATE'.
        /// '分解状态，0：未分解 1：已分解'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RESOLVE_STATE'.
        /// </value>
        public int ResolveState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRIORITY_OPERATOR'.
        /// '用户优先级'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRIORITY_OPERATOR'.
        /// </value>
        public int PriorityOperator { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_LOCATION_ID'.
        /// '拾取库位id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_LOCATION_ID'.
        /// </value>
        public string LoadLocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_LOCATION_NAME'.
        /// '拾取库位名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_LOCATION_NAME'.
        /// </value>
        public string LoadLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_LOCATION_ID'.
        /// '释放库位id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_LOCATION_ID'.
        /// </value>
        public string UnloadLocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_LOCATION_NAME'.
        /// '释放库位名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_LOCATION_NAME'.
        /// </value>
        public string UnloadLocationName { get; set; }

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

        /// <summary>
        /// Gets or sets the property value representing column 'IS_TRUCK_LOAD_FIXED'.
        /// '装车是否次序固定，0：不固定，1：固定'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_TRUCK_LOAD_FIXED'.
        /// </value>
        public int? IsTruckLoadFixed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_NO'.
        /// '装车车号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_NO'.
        /// </value>
        public string TruckNo { get; set; }

        #endregion

        #region Generated Relationships
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhBay" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhBay" />.
        /// </value>
        /// <seealso cref="BayId" />
        public virtual TWhBay BayTWhBay { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhLocation" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhLocation" />.
        /// </value>
        /// <seealso cref="LoadLocationId" />
        public virtual TWhLocation LoadLocationTWhLocation { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TPlMaterial" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TPlMaterial" />.
        /// </value>
        /// <seealso cref="MaterialId" />
        public virtual TPlMaterial MaterialTPlMaterial { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </value>
        public virtual ICollection<TPlCraneTask> OwnerTPlCraneTasks { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhPlanType" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhPlanType" />.
        /// </value>
        /// <seealso cref="PlanTypeId" />
        public virtual TWhPlanType PlanTypeTWhPlanType { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhLocation" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhLocation" />.
        /// </value>
        /// <seealso cref="UnloadLocationId" />
        public virtual TWhLocation UnloadLocationTWhLocation { get; set; }

        #endregion

    }
}
