using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 行车吊运任务表
    /// </summary>
    public partial class TPlCraneTaskUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TaskNo'.
        /// '计划号'.
        /// </summary>
        /// <value>
        /// The property value for 'TaskNo'.
        /// </value>
        public string TaskNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayName'.
        /// '跨名称'.
        /// </summary>
        /// <value>
        /// The property value for 'BayName'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CraneId'.
        /// '行车id'.
        /// </summary>
        /// <value>
        /// The property value for 'CraneId'.
        /// </value>
        public string CraneId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CraneName'.
        /// '行车名称'.
        /// </summary>
        /// <value>
        /// The property value for 'CraneName'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UserCraneId'.
        /// '用户更改行车'.
        /// </summary>
        /// <value>
        /// The property value for 'UserCraneId'.
        /// </value>
        public string UserCraneId { get; set; }

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
        /// '物料号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatWidth'.
        /// '物料宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'MatWidth'.
        /// </value>
        public int? MatWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatDiameter'.
        /// '物料外径'.
        /// </summary>
        /// <value>
        /// The property value for 'MatDiameter'.
        /// </value>
        public int? MatDiameter { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatWeight'.
        /// '物料重量'.
        /// </summary>
        /// <value>
        /// The property value for 'MatWeight'.
        /// </value>
        public int? MatWeight { get; set; }

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
        /// Gets or sets the property value for 'LoadX'.
        /// '拾取x'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadX'.
        /// </value>
        public decimal? LoadX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadY'.
        /// '拾取y'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadY'.
        /// </value>
        public decimal? LoadY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadZ'.
        /// '拾取z'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadZ'.
        /// </value>
        public decimal? LoadZ { get; set; }

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
        /// Gets or sets the property value for 'UnloadX'.
        /// '释放x'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadX'.
        /// </value>
        public decimal? UnloadX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadY'.
        /// '释放y'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadY'.
        /// </value>
        public decimal? UnloadY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadZ'.
        /// '释放z'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadZ'.
        /// </value>
        public decimal? UnloadZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanTypeId'.
        /// '任务类型ID'.
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
        /// Gets or sets the property value for 'OwnerId'.
        /// '跨内吊运计划ID'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SortIndexInOwner'.
        /// '在跨内吊运计划内的顺序'.
        /// </summary>
        /// <value>
        /// The property value for 'SortIndexInOwner'.
        /// </value>
        public int? SortIndexInOwner { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ExecState'.
        /// '执行状态  0：未执行 1：正在执行 2：已完成'.
        /// </summary>
        /// <value>
        /// The property value for 'ExecState'.
        /// </value>
        public int? ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PriorityDefault'.
        /// '优先级分数'.
        /// </summary>
        /// <value>
        /// The property value for 'PriorityDefault'.
        /// </value>
        public int? PriorityDefault { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PriorityOperator'.
        /// '操作员设置的附加优先级分数'.
        /// </summary>
        /// <value>
        /// The property value for 'PriorityOperator'.
        /// </value>
        public int? PriorityOperator { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AssignState'.
        /// '分配状态 0：不在分配池 1：等待分配 2：已分配'.
        /// </summary>
        /// <value>
        /// The property value for 'AssignState'.
        /// </value>
        public int? AssignState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CreateType'.
        /// '创建类型'.
        /// </summary>
        /// <value>
        /// The property value for 'CreateType'.
        /// </value>
        public int CreateType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UpdateType'.
        /// '更新类型'.
        /// </summary>
        /// <value>
        /// The property value for 'UpdateType'.
        /// </value>
        public int? UpdateType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsFrozon'.
        /// '是否冻结 1冻结，0取消'.
        /// </summary>
        /// <value>
        /// The property value for 'IsFrozon'.
        /// </value>
        public int? IsFrozon { get; set; }

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
