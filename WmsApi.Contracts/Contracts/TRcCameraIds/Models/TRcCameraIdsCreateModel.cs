using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 区域入侵摄像头追踪记录
    /// </summary>
    public partial class TRcCameraIdsCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CameraCode'.
        /// '设备编码'.
        /// </summary>
        /// <value>
        /// The property value for 'CameraCode'.
        /// </value>
        public string CameraCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CameraName'.
        /// '设备名称'.
        /// </summary>
        /// <value>
        /// The property value for 'CameraName'.
        /// </value>
        public string CameraName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AlarmChannelName'.
        /// '通道名称'.
        /// </summary>
        /// <value>
        /// The property value for 'AlarmChannelName'.
        /// </value>
        public string AlarmChannelName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AlarmType'.
        /// '报警类型 302-绊线入侵  303-区域入侵'.
        /// </summary>
        /// <value>
        /// The property value for 'AlarmType'.
        /// </value>
        public int? AlarmType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AlarmTime'.
        /// '报警时间'.
        /// </summary>
        /// <value>
        /// The property value for 'AlarmTime'.
        /// </value>
        public string AlarmTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AlarmState'.
        /// '报警状态 1-报警产生 2-报警消失'.
        /// </summary>
        /// <value>
        /// The property value for 'AlarmState'.
        /// </value>
        public int? AlarmState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AlarmPicture'.
        /// '报警图片地址'.
        /// </summary>
        /// <value>
        /// The property value for 'AlarmPicture'.
        /// </value>
        public string AlarmPicture { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// 'BayId'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayName'.
        /// 'BayName'.
        /// </summary>
        /// <value>
        /// The property value for 'BayName'.
        /// </value>
        public string BayName { get; set; }

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
