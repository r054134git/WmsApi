using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_um_group'.
    /// </summary>
    public partial class TUmGroup
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmGroup"/> class.
        /// 班组信息
        /// </summary>
        public TUmGroup()
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
        /// Gets or sets the property value representing column 'NAME'.
        /// '班组名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA'.
        /// '库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA'.
        /// </value>
        public string Area { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GAFFER_NAME'.
        /// '所属领班姓名(若为领班表示当前用户是领班)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GAFFER_NAME'.
        /// </value>
        public string GafferName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'USER_NAME'.
        /// '用户姓名'.
        /// </summary>
        /// <value>
        /// The property value representing column 'USER_NAME'.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'USER_ACCOUNT'.
        /// '用户工号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'USER_ACCOUNT'.
        /// </value>
        public string UserAccount { get; set; }

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
