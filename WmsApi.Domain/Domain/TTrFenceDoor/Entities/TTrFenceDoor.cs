using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_fence_door'.
    /// </summary>
    public partial class TTrFenceDoor
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrFenceDoor"/> class.
        /// 安全门的跟踪
        /// </summary>
        public TTrFenceDoor()
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
        /// Gets or sets the property value representing column 'FENCE_ID'.
        /// '围栏区'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FENCE_ID'.
        /// </value>
        public string FenceId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FENCE_DOOR_ID'.
        /// '安全门'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FENCE_DOOR_ID'.
        /// </value>
        public string FenceDoorId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FENCE_DOOR_CODE'.
        /// '围栏区Code'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FENCE_DOOR_CODE'.
        /// </value>
        public string FenceDoorCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FENCE_DOOR_STATE'.
        /// '安全门状态，0：未知，1：开  2：关 3：急停开'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FENCE_DOOR_STATE'.
        /// </value>
        public int FenceDoorState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FENCE_DOOR_REQUEST'.
        /// '当前有无请求，0：未知，1：开门请求，2：关门请求'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FENCE_DOOR_REQUEST'.
        /// </value>
        public int FenceDoorRequest { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REQUEST_SOURCE'.
        /// '请求方式，0：无，1：手持机，2：安全门按钮 3：按钮急停'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REQUEST_SOURCE'.
        /// </value>
        public int RequestSource { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REQUEST_USER'.
        /// '请求用户'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REQUEST_USER'.
        /// </value>
        public string RequestUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REQUEST_TIME'.
        /// '请求时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REQUEST_TIME'.
        /// </value>
        public DateTime? RequestTime { get; set; }

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
