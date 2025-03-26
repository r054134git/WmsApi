using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TTrCrossTrainReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'VehicleId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleId'.
        /// </value>
        public string VehicleId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VehicleType'.
        /// '过跨设备类型 0：无，1：汽车，2：过跨车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleType'.
        /// </value>
        public int VehicleType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VehicleName'.
        /// '车辆名称（WMS显示）'.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleName'.
        /// </value>
        public string VehicleName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VehiclePlcName'.
        /// '车辆名称（PLC name）'.
        /// </summary>
        /// <value>
        /// The property value for 'VehiclePlcName'.
        /// </value>
        public string VehiclePlcName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ParkedState'.
        /// '停车状态，1：停在装车位，2：停在卸车位，3：行进中'.
        /// </summary>
        /// <value>
        /// The property value for 'ParkedState'.
        /// </value>
        public int? ParkedState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromBayName'.
        /// '起点跨名称'.
        /// </summary>
        /// <value>
        /// The property value for 'FromBayName'.
        /// </value>
        public string FromBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestBayName'.
        /// '目的跨名称'.
        /// </summary>
        /// <value>
        /// The property value for 'DestBayName'.
        /// </value>
        public string DestBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TaskType'.
        /// '作业类型，1：库间倒运，2：过跨倒运'.
        /// </summary>
        /// <value>
        /// The property value for 'TaskType'.
        /// </value>
        public int? TaskType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StackId'.
        /// 'STACK ID'.
        /// </summary>
        /// <value>
        /// The property value for 'StackId'.
        /// </value>
        public string StackId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LaserDistance'.
        /// '过跨车，当前激光距离，单位（米）'.
        /// </summary>
        /// <value>
        /// The property value for 'LaserDistance'.
        /// </value>
        public decimal? LaserDistance { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OperationMode'.
        /// '过跨车操作模式，0：手动，1：自动'.
        /// </summary>
        /// <value>
        /// The property value for 'OperationMode'.
        /// </value>
        public int? OperationMode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsLock'.
        /// '过跨车锁定状态，0：解锁，1：锁定'.
        /// </summary>
        /// <value>
        /// The property value for 'IsLock'.
        /// </value>
        public int? IsLock { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FaultCode'.
        /// '过跨车，错误代码'.
        /// </summary>
        /// <value>
        /// The property value for 'FaultCode'.
        /// </value>
        public int? FaultCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FaultDesc'.
        /// '过跨车，错误描述'.
        /// </summary>
        /// <value>
        /// The property value for 'FaultDesc'.
        /// </value>
        public string FaultDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TaskNoWms'.
        /// '执行的任务编号'.
        /// </summary>
        /// <value>
        /// The property value for 'TaskNoWms'.
        /// </value>
        public string TaskNoWms { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TaskNoPlc'.
        /// '执行的任务编号+1、2'.
        /// </summary>
        /// <value>
        /// The property value for 'TaskNoPlc'.
        /// </value>
        public string TaskNoPlc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TaskState'.
        /// '执行任务状态，0：未执行，1：正在执行，2：执行完成，3：暂停执行，4：执行失败'.
        /// </summary>
        /// <value>
        /// The property value for 'TaskState'.
        /// </value>
        public int? TaskState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TaskTime'.
        /// '发送任务时间'.
        /// </summary>
        /// <value>
        /// The property value for 'TaskTime'.
        /// </value>
        public DateTime? TaskTime { get; set; }

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
