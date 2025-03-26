using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TTrTodoListReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'BayName'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BayName'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Description'.
        /// '描述'.
        /// </summary>
        /// <value>
        /// The property value for 'Description'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EventNo'.
        /// '事件编号'.
        /// </summary>
        /// <value>
        /// The property value for 'EventNo'.
        /// </value>
        public int? EventNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Sender'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Sender'.
        /// </value>
        public string Sender { get; set; }

        #endregion

    }
}
