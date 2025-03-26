using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
	/// <summary>
	/// View Model class
	/// 数据字典表
	/// </summary>
	public partial class TScDictionaryCreateModel
		: EntityCreateModel
	{
		#region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Key'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Key'.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Value'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Value'.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Seq'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Seq'.
        /// </value>
        public int Seq { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Owner'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Owner'.
        /// </value>
        public string Owner { get; set; }

        #endregion

	}
}
