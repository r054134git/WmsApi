using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 班组信息
    /// </summary>
    public partial class TUmGroupReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '班组名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Area'.
        /// '库'.
        /// </summary>
        /// <value>
        /// The property value for 'Area'.
        /// </value>
        public string Area { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GafferName'.
        /// '所属领班姓名(若为领班表示当前用户是领班)'.
        /// </summary>
        /// <value>
        /// The property value for 'GafferName'.
        /// </value>
        public string GafferName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UserName'.
        /// '用户姓名'.
        /// </summary>
        /// <value>
        /// The property value for 'UserName'.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UserAccount'.
        /// '用户工号'.
        /// </summary>
        /// <value>
        /// The property value for 'UserAccount'.
        /// </value>
        public string UserAccount { get; set; }

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
