using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 角色权限关联信息
    /// </summary>
    public partial class TUmRolePermissionUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'RoleId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RoleId'.
        /// </value>
        public string RoleId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PermissionId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PermissionId'.
        /// </value>
        public string PermissionId { get; set; }

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
