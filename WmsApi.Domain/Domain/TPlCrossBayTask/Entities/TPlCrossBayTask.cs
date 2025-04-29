using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_cross_bay_task'.
    /// </summary>
    public partial class TPlCrossBayTask
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlCrossBayTask"/> class.
        /// 过跨车任务表
        /// </summary>
        public TPlCrossBayTask()
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
        /// '任务编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TASK_NO'.
        /// </value>
        public string TaskNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_ID'.
        /// </value>
        public string VehicleId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_TYPE'.
        /// '车辆类型，0：无，1：过跨车，2：汽车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_TYPE'.
        /// </value>
        public int VehicleType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_NAME'.
        /// '车辆名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_NAME'.
        /// </value>
        public string VehicleName { get; set; }

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
        /// '起点跨名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_BAY_NAME'.
        /// </value>
        public string FromBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_BAY_ID'.
        /// '目的跨'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_BAY_ID'.
        /// </value>
        public string DestBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_BAY_NAME'.
        /// '目的跨名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_BAY_NAME'.
        /// </value>
        public string DestBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TASK_STATE'.
        /// '执行状态  0：未执行，1：正在执行，2：已完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TASK_STATE'.
        /// </value>
        public int TaskState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPATCH_STATE'.
        /// '车辆调度状态，0：无，1：正在前往装车位，2：已到达装车位，3：正在前往卸车位，4：已到达卸车位，5：装车完成，6：卸车完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPATCH_STATE'.
        /// </value>
        public int DispatchState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO_PLAN'.
        /// '计划装载钢卷信息列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO_PLAN'.
        /// </value>
        public string MaterialNoPlan { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO_LOADED'.
        /// '实际装载钢卷信息列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO_LOADED'.
        /// </value>
        public string MaterialNoLoaded { get; set; }

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

        #endregion

    }
}
