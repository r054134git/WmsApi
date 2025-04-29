using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 设置列
    /// </summary>
    public partial class TUmColSetReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TableName'.
        /// '页名'.
        /// </summary>
        /// <value>
        /// The property value for 'TableName'.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Type'.
        /// '列类型'.
        /// </summary>
        /// <value>
        /// The property value for 'Type'.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Title'.
        /// '列名'.
        /// </summary>
        /// <value>
        /// The property value for 'Title'.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DataIndex'.
        /// '列字段'.
        /// </summary>
        /// <value>
        /// The property value for 'DataIndex'.
        /// </value>
        public string DataIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HideInSearch'.
        /// '是否显示搜索'.
        /// </summary>
        /// <value>
        /// The property value for 'HideInSearch'.
        /// </value>
        public int? HideInSearch { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HideInTable'.
        /// '是否显示列'.
        /// </summary>
        /// <value>
        /// The property value for 'HideInTable'.
        /// </value>
        public int? HideInTable { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Filters'.
        /// '筛选条件'.
        /// </summary>
        /// <value>
        /// The property value for 'Filters'.
        /// </value>
        public string Filters { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Selects'.
        /// '下拉条件'.
        /// </summary>
        /// <value>
        /// The property value for 'Selects'.
        /// </value>
        public string Selects { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Width'.
        /// '宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'Width'.
        /// </value>
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Sort'.
        /// '排序'.
        /// </summary>
        /// <value>
        /// The property value for 'Sort'.
        /// </value>
        public int? Sort { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HideInEdit'.
        /// '是否编辑'.
        /// </summary>
        /// <value>
        /// The property value for 'HideInEdit'.
        /// </value>
        public int? HideInEdit { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Rules'.
        /// '是否必填'.
        /// </summary>
        /// <value>
        /// The property value for 'Rules'.
        /// </value>
        public int? Rules { get; set; }

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
