using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_wh_dest_house'.
    /// </summary>
    public partial class TWhDestHouse
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhDestHouse"/> class.
        /// 
        /// </summary>
        public TWhDestHouse()
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
        /// Gets or sets the property value representing column 'DEST_HOUSE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_HOUSE'.
        /// </value>
        public string DestHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_CODE'.
        /// </value>
        public string DestCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ENABLE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ENABLE'.
        /// </value>
        public int IsEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_USER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_USER'.
        /// </value>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_TIME'.
        /// </value>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_USER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_USER'.
        /// </value>
        public string UpdateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMARK'.
        /// ''.
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
