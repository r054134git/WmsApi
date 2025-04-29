using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_eq_gate_entry'.
    /// </summary>
    public partial class TEqGateEntry
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqGateEntry"/> class.
        /// 库区入口道闸
        /// </summary>
        public TEqGateEntry()
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
        /// Gets or sets the property value representing column 'GATE_ID'.
        /// '大华道闸内部ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GATE_ID'.
        /// </value>
        public string GateId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IP_GATE'.
        /// 'IP地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IP_GATE'.
        /// </value>
        public string IpGate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IP_LED'.
        /// 'IP地址(LED)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IP_LED'.
        /// </value>
        public string IpLed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// '父id（BAY）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_BAY_ID_LIST'.
        /// '可以通过该库区入口道闸到达的所有库区列表，以逗号（，）分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_BAY_ID_LIST'.
        /// </value>
        public string EntryBayIdList { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ENABLE'.
        /// '是否可用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ENABLE'.
        /// </value>
        public int? IsEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// '创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime? CreateTime { get; set; }

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
        public DateTime? UpdateTime { get; set; }

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
