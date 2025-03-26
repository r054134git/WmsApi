using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_um_user'.
    /// </summary>
    public partial class TUmUser
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmUser"/> class.
        /// 用户信息表
        /// </summary>
        public TUmUser()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// '用户ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ACCOUNT'.
        /// '用户账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ACCOUNT'.
        /// </value>
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NAME'.
        /// '用户名'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PASSWORD'.
        /// '用户密码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PASSWORD'.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TEAM_ID'.
        /// '所属班组'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TEAM_ID'.
        /// </value>
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Department'.
        /// '所属部门'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Department'.
        /// </value>
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ROLE_ID'.
        /// '角色ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROLE_ID'.
        /// </value>
        public string RoleId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LAST_LOGIN_TIME'.
        /// '上次登录日期'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LAST_LOGIN_TIME'.
        /// </value>
        public DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID_NAME_LIST'.
        /// '可以访问的跨(id,name)列表json'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID_NAME_LIST'.
        /// </value>
        public string BayIdNameList { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TUmRole" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TUmRole" />.
        /// </value>
        /// <seealso cref="RoleId" />
        public virtual TUmRole RoleTUmRole { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TScDictionary" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TScDictionary" />.
        /// </value>
        /// <seealso cref="TeamId" />
        public virtual TScDictionary TeamTScDictionary { get; set; }

        #endregion

    }
}
