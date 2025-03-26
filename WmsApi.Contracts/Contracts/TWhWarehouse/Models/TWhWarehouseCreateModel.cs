using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库区基础信息
    /// </summary>
    public partial class TWhWarehouseCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Company'.
        /// '所属单位'.
        /// </summary>
        /// <value>
        /// The property value for 'Company'.
        /// </value>
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Workshop'.
        /// '所属车间'.
        /// </summary>
        /// <value>
        /// The property value for 'Workshop'.
        /// </value>
        public string Workshop { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadPriority'.
        /// '汽车发货的装车优先级。0：卷优先；1：板优先'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadPriority'.
        /// </value>
        public int LoadPriority { get; set; }

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
