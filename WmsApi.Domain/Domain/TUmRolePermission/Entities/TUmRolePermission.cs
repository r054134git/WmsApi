using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_um_role_permission'.
    /// </summary>
    public partial class TUmRolePermission
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmRolePermission"/> class.
        /// 角色权限关联信息
        /// </summary>
        public TUmRolePermission()
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
        /// Gets or sets the property value representing column 'ROLE_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROLE_ID'.
        /// </value>
        public string RoleId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PERMISSION_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PERMISSION_ID'.
        /// </value>
        public string PermissionId { get; set; }

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
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TUmMenu" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TUmMenu" />.
        /// </value>
        /// <seealso cref="PermissionId" />
        public virtual TUmMenu PermissionTUmMenu { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TUmRole" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TUmRole" />.
        /// </value>
        /// <seealso cref="RoleId" />
        public virtual TUmRole RoleTUmRole { get; set; }

        #endregion

    }
}
