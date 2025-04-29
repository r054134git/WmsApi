using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_todo_list'.
    /// </summary>
    public partial class TTrTodoList
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTodoList"/> class.
        /// 
        /// </summary>
        public TTrTodoList()
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
        /// Gets or sets the property value representing column 'BAY_NAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_NAME'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// '创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DESCRIPTION'.
        /// '描述'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DESCRIPTION'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EVENT_NO'.
        /// '事件编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EVENT_NO'.
        /// </value>
        public int? EventNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SENDER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SENDER'.
        /// </value>
        public string Sender { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
