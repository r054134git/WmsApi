using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TUmMenuUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '菜单名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Code'.
        /// '菜单编码'.
        /// </summary>
        /// <value>
        /// The property value for 'Code'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// '父级菜单ID'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Path'.
        /// '路径'.
        /// </summary>
        /// <value>
        /// The property value for 'Path'.
        /// </value>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Seq'.
        /// '排序'.
        /// </summary>
        /// <value>
        /// The property value for 'Seq'.
        /// </value>
        public int? Seq { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Icon'.
        /// '图标'.
        /// </summary>
        /// <value>
        /// The property value for 'Icon'.
        /// </value>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsShow'.
        /// '隐藏菜单'.
        /// </summary>
        /// <value>
        /// The property value for 'IsShow'.
        /// </value>
        public int IsShow { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsRouter'.
        /// '是否路由'.
        /// </summary>
        /// <value>
        /// The property value for 'IsRouter'.
        /// </value>
        public int IsRouter { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Description'.
        /// '描述'.
        /// </summary>
        /// <value>
        /// The property value for 'Description'.
        /// </value>
        public string Description { get; set; }

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
