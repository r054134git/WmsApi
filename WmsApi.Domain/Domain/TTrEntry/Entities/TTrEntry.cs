using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_entry'.
    /// </summary>
    public partial class TTrEntry
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrEntry"/> class.
        /// 库区入口道闸状态的追踪
        /// </summary>
        public TTrEntry()
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
        /// Gets or sets the property value representing column 'GATE_ID'.
        /// '库区道闸id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GATE_ID'.
        /// </value>
        public string GateId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NAME'.
        /// '道闸名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CODE'.
        /// '唯一代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CODE'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GATE_STATE'.
        /// '库区道闸状态，0：关闭（杆落下），1：开启（杆抬起）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GATE_STATE'.
        /// </value>
        public int GateState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LED_CONTENT'.
        /// 'IP地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LED_CONTENT'.
        /// </value>
        public string LedContent { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_USING'.
        /// '库区道闸是否在使用，0：无，1：是'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_USING'.
        /// </value>
        public int IsUsing { get; set; }

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
