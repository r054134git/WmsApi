using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 过跨车任务表
    /// </summary>
    public partial class TPlCrossBayTaskReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TaskNo'.
        /// '任务编号'.
        /// </summary>
        /// <value>
        /// The property value for 'TaskNo'.
        /// </value>
        public string TaskNo { get; set; }

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
        /// '车辆类型，0：无，1：过跨车，2：汽车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleType'.
        /// </value>
        public int VehicleType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VehicleName'.
        /// '车辆名称'.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleName'.
        /// </value>
        public string VehicleName { get; set; }

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
        /// '起点跨名称'.
        /// </summary>
        /// <value>
        /// The property value for 'FromBayName'.
        /// </value>
        public string FromBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestBayId'.
        /// '目的跨'.
        /// </summary>
        /// <value>
        /// The property value for 'DestBayId'.
        /// </value>
        public string DestBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestBayName'.
        /// '目的跨名称'.
        /// </summary>
        /// <value>
        /// The property value for 'DestBayName'.
        /// </value>
        public string DestBayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TaskState'.
        /// '执行状态  0：未执行，1：正在执行，2：已完成'.
        /// </summary>
        /// <value>
        /// The property value for 'TaskState'.
        /// </value>
        public int TaskState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DispatchState'.
        /// '车辆调度状态，0：无，1：正在前往装车位，2：已到达装车位，3：正在前往卸车位，4：已到达卸车位，5：装车完成，6：卸车完成'.
        /// </summary>
        /// <value>
        /// The property value for 'DispatchState'.
        /// </value>
        public int DispatchState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNoPlan'.
        /// '计划装载钢卷信息列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNoPlan'.
        /// </value>
        public string MaterialNoPlan { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNoLoaded'.
        /// '实际装载钢卷信息列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNoLoaded'.
        /// </value>
        public string MaterialNoLoaded { get; set; }

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
