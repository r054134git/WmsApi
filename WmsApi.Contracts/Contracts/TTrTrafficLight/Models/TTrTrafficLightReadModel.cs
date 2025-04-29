using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 吊车追踪
    /// </summary>
    public partial class TTrTrafficLightReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '红绿灯名称（如：16库）'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlcName'.
        /// '红绿灯的PLC名称'.
        /// </summary>
        /// <value>
        /// The property value for 'PlcName'.
        /// </value>
        public string PlcName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '库id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'State'.
        /// '红绿灯状态（0：不亮；1：红灯亮；2绿灯亮； 3：全部亮；4：双灯闪烁）'.
        /// </summary>
        /// <value>
        /// The property value for 'State'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LastCmd'.
        /// '上次请求状态：0：不亮；1：红灯亮；2绿灯亮； 3：全部亮；4：双灯闪烁'.
        /// </summary>
        /// <value>
        /// The property value for 'LastCmd'.
        /// </value>
        public int? LastCmd { get; set; }

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
