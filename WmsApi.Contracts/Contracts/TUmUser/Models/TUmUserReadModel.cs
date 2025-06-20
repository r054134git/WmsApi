using System;
using System.Collections.Generic;
using System.Linq;

namespace WmsApi.Contracts.Models
{
	/// <summary>
	/// View Model class
	/// 用户信息表
	/// </summary>
	public partial class TUmUserReadModel
		: EntityReadModel
	{
		#region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Account'.
        /// '用户账号'.
        /// </summary>
        /// <value>
        /// The property value for 'Account'.
        /// </value>
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '用户名'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Password'.
        /// '用户密码'.
        /// </summary>
        /// <value>
        /// The property value for 'Password'.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TeamId'.
        /// '所属班组'.
        /// </summary>
        /// <value>
        /// The property value for 'TeamId'.
        /// </value>
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Department'.
        /// '所属部门'.
        /// </summary>
        /// <value>
        /// The property value for 'Department'.
        /// </value>
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RoleId'.
        /// '角色ID'.
        /// </summary>
        /// <value>
        /// The property value for 'RoleId'.
        /// </value>
        public string RoleId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LastLoginTime'.
        /// '上次登录日期'.
        /// </summary>
        /// <value>
        /// The property value for 'LastLoginTime'.
        /// </value>
        public DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayIdNameList'.
        /// '可以访问的跨(id,name)列表json'.
        /// </summary>
        /// <value>
        /// The property value for 'BayIdNameList'.
        /// </value>
        public string BayIdNameList { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion

        public string Id { get; set; }
		public string TeamName { get; set; }

		public string RoleName { get; set; }

		public List<BayIdName> BayIdNames { get; set; } = new List<BayIdName>();

        public string BayNames { get { return string.Join(",", BayIdNames.Select(t => t.BayName)); } }
    }
}