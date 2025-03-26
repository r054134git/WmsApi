using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_um_menu'.
    /// </summary>
    public partial class TUmMenu
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmMenu"/> class.
        /// 
        /// </summary>
        public TUmMenu()
        {
            #region Generated Constructor
            PermissionTUmRolePermissions = new HashSet<TUmRolePermission>();
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
        /// '菜单名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CODE'.
        /// '菜单编码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CODE'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// '父级菜单ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PATH'.
        /// '路径'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PATH'.
        /// </value>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SEQ'.
        /// '排序'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SEQ'.
        /// </value>
        public int? Seq { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ICON'.
        /// '图标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ICON'.
        /// </value>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SHOW'.
        /// '隐藏菜单'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SHOW'.
        /// </value>
        public int IsShow { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ROUTER'.
        /// '是否路由'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ROUTER'.
        /// </value>
        public int IsRouter { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DESCRIPTION'.
        /// '描述'.
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
        public virtual ICollection<TUmRolePermission> PermissionTUmRolePermissions { get; set; }

        #endregion

    }
}
