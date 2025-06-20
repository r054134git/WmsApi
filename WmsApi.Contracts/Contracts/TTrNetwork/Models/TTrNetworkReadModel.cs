using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 网络节点通讯状态监控
    /// </summary>
    public partial class TTrNetworkReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '节点名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IpAddress'.
        /// 'IP地址'.
        /// </summary>
        /// <value>
        /// The property value for 'IpAddress'.
        /// </value>
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsConnected'.
        /// '0：已断开，1：正常'.
        /// </summary>
        /// <value>
        /// The property value for 'IsConnected'.
        /// </value>
        public int IsConnected { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// '父节点id'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Sort'.
        /// '排序'.
        /// </summary>
        /// <value>
        /// The property value for 'Sort'.
        /// </value>
        public int Sort { get; set; }

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
