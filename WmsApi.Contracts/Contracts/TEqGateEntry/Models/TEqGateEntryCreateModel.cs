using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库区入口道闸
    /// </summary>
    public partial class TEqGateEntryCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '道闸名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Code'.
        /// '唯一代码'.
        /// </summary>
        /// <value>
        /// The property value for 'Code'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GateId'.
        /// '大华道闸内部ID'.
        /// </summary>
        /// <value>
        /// The property value for 'GateId'.
        /// </value>
        public string GateId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IpGate'.
        /// 'IP地址'.
        /// </summary>
        /// <value>
        /// The property value for 'IpGate'.
        /// </value>
        public string IpGate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IpLed'.
        /// 'IP地址(LED)'.
        /// </summary>
        /// <value>
        /// The property value for 'IpLed'.
        /// </value>
        public string IpLed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// '父id（BAY）'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryBayIdList'.
        /// '可以通过该库区入口道闸到达的所有库区列表，以逗号（，）分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryBayIdList'.
        /// </value>
        public string EntryBayIdList { get; set; }

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
