using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_camera_ids'.
    /// </summary>
    public partial class TRcCameraIds
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcCameraIds"/> class.
        /// 区域入侵摄像头追踪记录
        /// </summary>
        public TRcCameraIds()
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
        /// Gets or sets the property value representing column 'CAMERA_CODE'.
        /// '设备编码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAMERA_CODE'.
        /// </value>
        public string CameraCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAMERA_NAME'.
        /// '设备名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAMERA_NAME'.
        /// </value>
        public string CameraName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ALARM_CHANNEL_NAME'.
        /// '通道名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ALARM_CHANNEL_NAME'.
        /// </value>
        public string AlarmChannelName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ALARM_TYPE'.
        /// '报警类型 302-绊线入侵  303-区域入侵'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ALARM_TYPE'.
        /// </value>
        public int? AlarmType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ALARM_TIME'.
        /// '报警时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ALARM_TIME'.
        /// </value>
        public string AlarmTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ALARM_STATE'.
        /// '报警状态 1-报警产生 2-报警消失'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ALARM_STATE'.
        /// </value>
        public int? AlarmState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ALARM_PICTURE'.
        /// '报警图片地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ALARM_PICTURE'.
        /// </value>
        public string AlarmPicture { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// 'BayId'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_NAME'.
        /// 'BayName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_NAME'.
        /// </value>
        public string BayName { get; set; }

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
