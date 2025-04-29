using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_crane_task'.
    /// </summary>
    public partial class TPlCraneTask
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlCraneTask"/> class.
        /// 行车吊运任务表
        /// </summary>
        public TPlCraneTask()
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
        /// Gets or sets the property value representing column 'TASK_NO'.
        /// '计划号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TASK_NO'.
        /// </value>
        public string TaskNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_NAME'.
        /// '跨名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_NAME'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_ID'.
        /// '行车id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_ID'.
        /// </value>
        public string CraneId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_NAME'.
        /// '行车名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_NAME'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'USER_CRANE_ID'.
        /// '用户更改行车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'USER_CRANE_ID'.
        /// </value>
        public string UserCraneId { get; set; }

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
        /// '物料号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_WIDTH'.
        /// '物料宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_WIDTH'.
        /// </value>
        public int? MatWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_DIAMETER'.
        /// '物料外径'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_DIAMETER'.
        /// </value>
        public int? MatDiameter { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_WEIGHT'.
        /// '物料重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_WEIGHT'.
        /// </value>
        public int? MatWeight { get; set; }

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
        /// Gets or sets the property value representing column 'LOAD_X'.
        /// '拾取x'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_X'.
        /// </value>
        public decimal? LoadX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_Y'.
        /// '拾取y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_Y'.
        /// </value>
        public decimal? LoadY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_Z'.
        /// '拾取z'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_Z'.
        /// </value>
        public decimal? LoadZ { get; set; }

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
        /// Gets or sets the property value representing column 'UNLOAD_X'.
        /// '释放x'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_X'.
        /// </value>
        public decimal? UnloadX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_Y'.
        /// '释放y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_Y'.
        /// </value>
        public decimal? UnloadY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_Z'.
        /// '释放z'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_Z'.
        /// </value>
        public decimal? UnloadZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_ID'.
        /// '任务类型ID'.
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
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// '跨内吊运计划ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORT_INDEX_IN_OWNER'.
        /// '在跨内吊运计划内的顺序'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT_INDEX_IN_OWNER'.
        /// </value>
        public int? SortIndexInOwner { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EXEC_STATE'.
        /// '执行状态  0：未执行 1：正在执行 2：已完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EXEC_STATE'.
        /// </value>
        public int? ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRIORITY_DEFAULT'.
        /// '优先级分数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRIORITY_DEFAULT'.
        /// </value>
        public int? PriorityDefault { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRIORITY_OPERATOR'.
        /// '操作员设置的附加优先级分数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRIORITY_OPERATOR'.
        /// </value>
        public int? PriorityOperator { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ASSIGN_STATE'.
        /// '分配状态 0：不在分配池 1：等待分配 2：已分配'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ASSIGN_STATE'.
        /// </value>
        public int? AssignState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TYPE'.
        /// '创建类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TYPE'.
        /// </value>
        public int CreateType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_TYPE'.
        /// '更新类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_TYPE'.
        /// </value>
        public int? UpdateType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_FROZON'.
        /// '是否冻结 1冻结，0取消'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_FROZON'.
        /// </value>
        public int? IsFrozon { get; set; }

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
        /// <seealso cref="BayId" />
        public virtual TWhBay BayTWhBay { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TEqCrane" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TEqCrane" />.
        /// </value>
        /// <seealso cref="CraneId" />
        public virtual TEqCrane CraneTEqCrane { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TPlBay" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TPlBay" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TPlBay OwnerTPlBay { get; set; }

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
