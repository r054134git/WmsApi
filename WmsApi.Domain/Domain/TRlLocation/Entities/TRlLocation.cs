using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rl_location'.
    /// </summary>
    public partial class TRlLocation
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlLocation"/> class.
        /// 库位规则表
        /// </summary>
        public TRlLocation()
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
        /// Gets or sets the property value representing column 'SORT_INDEX'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT_INDEX'.
        /// </value>
        public int? SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HANDLE_DESC'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'HANDLE_DESC'.
        /// </value>
        public string HandleDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCRIPT_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCRIPT_CODE'.
        /// </value>
        public string ScriptCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ENABLE'.
        /// '是否可用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ENABLE'.
        /// </value>
        public int IsEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// '创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_USER'.
        /// '创建人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_USER'.
        /// </value>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_TIME'.
        /// '更新时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_TIME'.
        /// </value>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_USER'.
        /// '更新人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_USER'.
        /// </value>
        public string UpdateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMARK'.
        /// '备注'.
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
