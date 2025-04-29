using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_work_mode'.
    /// </summary>
    public partial class TRcWorkMode
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcWorkMode"/> class.
        /// 
        /// </summary>
        public TRcWorkMode()
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
        /// Gets or sets the property value representing column 'CRANE_NAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_NAME'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_MODE'.
        /// '行车状态  1：手动 3：自动'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_MODE'.
        /// </value>
        public int FromMode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TO_MODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TO_MODE'.
        /// </value>
        public int ToMode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
