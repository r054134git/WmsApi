using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_bay'.
    /// </summary>
    public partial class TRcBay
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcBay"/> class.
        /// 跨内吊运计划表
        /// </summary>
        public TRcBay()
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
        /// '0:未处理 1：已排库位   2：预排任务  4：已生成任务'.
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
        /// '拾取库位编号'.
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
        /// Gets or sets the property value representing column 'UNLOAD_LOCATION_ID'.
        /// '释放库位id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_LOCATION_ID'.
        /// </value>
        public string UnloadLocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_LOCATION_NAME'.
        /// '释放库位编号'.
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
        /// Gets or sets the property value representing column 'IN_OUT_TYPE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_OUT_TYPE'.
        /// </value>
        public int? InOutType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'START_TIME'.
        /// '开始时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'START_TIME'.
        /// </value>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'END_TIME'.
        /// '结束时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'END_TIME'.
        /// </value>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'USER_ACCOUNT'.
        /// '用户'.
        /// </summary>
        /// <value>
        /// The property value representing column 'USER_ACCOUNT'.
        /// </value>
        public string UserAccount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SHIFT'.
        /// '班组'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SHIFT'.
        /// </value>
        public string Shift { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TEAM'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TEAM'.
        /// </value>
        public string Team { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FINISH_TYPE'.
        /// '完成类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FINISH_TYPE'.
        /// </value>
        public int? FinishType { get; set; }

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
        #endregion

    }
}
