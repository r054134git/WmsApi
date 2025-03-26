using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_um_role'.
    /// </summary>
    public partial class TUmRole
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmRole"/> class.
        /// 角色信息表
        /// </summary>
        public TUmRole()
        {
            #region Generated Constructor
            RoleTUmRolePermissions = new HashSet<TUmRolePermission>();
            RoleTUmUsers = new HashSet<TUmUser>();
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
        /// Gets or sets the property value representing column 'NAME'.
        /// '角色名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DESCRIPTION'.
        /// '角色描述'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DESCRIPTION'.
        /// </value>
        public string Description { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="TUmRolePermission" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TUmRolePermission" />.
        /// </value>
        public virtual ICollection<TUmRolePermission> RoleTUmRolePermissions { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TUmUser" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TUmUser" />.
        /// </value>
        public virtual ICollection<TUmUser> RoleTUmUsers { get; set; }

        #endregion

    }
}
