using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 数据字典表
    /// </summary>
    public partial class TScTransferTerminalUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CodeNumber'.
        /// '代码编号'.
        /// </summary>
        /// <value>
        /// The property value for 'CodeNumber'.
        /// </value>
        public string CodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Code'.
        /// '代码'.
        /// </summary>
        /// <value>
        /// The property value for 'Code'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CityName'.
        /// '终点码头'.
        /// </summary>
        /// <value>
        /// The property value for 'CityName'.
        /// </value>
        public string CityName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BelongCityName'.
        /// '所属终点码头'.
        /// </summary>
        /// <value>
        /// The property value for 'BelongCityName'.
        /// </value>
        public string BelongCityName { get; set; }

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
