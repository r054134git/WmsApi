using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_cross_train'.
    /// </summary>
    public partial class TTrCrossTrain
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCrossTrain"/> class.
        /// 
        /// </summary>
        public TTrCrossTrain()
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
        /// Gets or sets the property value representing column 'VEHICLE_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_ID'.
        /// </value>
        public string VehicleId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_TYPE'.
        /// '过跨设备类型 0：无，1：汽车，2：过跨车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_TYPE'.
        /// </value>
        public int VehicleType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_NAME'.
        /// '车辆名称（WMS显示）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_NAME'.
        /// </value>
        public string VehicleName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_PLC_NAME'.
        /// '车辆名称（PLC name）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_PLC_NAME'.
        /// </value>
        public string VehiclePlcName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PARKED_STATE'.
        /// '停车状态，1：停在装车位，2：停在卸车位，3：行进中'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PARKED_STATE'.
        /// </value>
        public int? ParkedState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_BAY_NAME'.
        /// '起点跨名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_BAY_NAME'.
        /// </value>
        public string FromBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_BAY_NAME'.
        /// '目的跨名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_BAY_NAME'.
        /// </value>
        public string DestBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TASK_TYPE'.
        /// '作业类型，1：库间倒运，2：过跨倒运'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TASK_TYPE'.
        /// </value>
        public int? TaskType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STACK_ID'.
        /// 'STACK ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STACK_ID'.
        /// </value>
        public string StackId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LASER_DISTANCE'.
        /// '过跨车，当前激光距离，单位（米）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LASER_DISTANCE'.
        /// </value>
        public decimal? LaserDistance { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OPERATION_MODE'.
        /// '过跨车操作模式，0：手动，1：自动'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OPERATION_MODE'.
        /// </value>
        public int? OperationMode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_LOCK'.
        /// '过跨车锁定状态，0：解锁，1：锁定'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_LOCK'.
        /// </value>
        public int? IsLock { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FAULT_CODE'.
        /// '过跨车，错误代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FAULT_CODE'.
        /// </value>
        public int? FaultCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FAULT_DESC'.
        /// '过跨车，错误描述'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FAULT_DESC'.
        /// </value>
        public string FaultDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TASK_NO_WMS'.
        /// '执行的任务编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TASK_NO_WMS'.
        /// </value>
        public string TaskNoWms { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TASK_NO_PLC'.
        /// '执行的任务编号+1、2'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TASK_NO_PLC'.
        /// </value>
        public string TaskNoPlc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TASK_STATE'.
        /// '执行任务状态，0：未执行，1：正在执行，2：执行完成，3：暂停执行，4：执行失败'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TASK_STATE'.
        /// </value>
        public int? TaskState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TASK_TIME'.
        /// '发送任务时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TASK_TIME'.
        /// </value>
        public DateTime? TaskTime { get; set; }

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
