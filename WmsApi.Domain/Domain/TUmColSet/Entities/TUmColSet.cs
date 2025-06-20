using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_um_col_set'.
    /// </summary>
    public partial class TUmColSet
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmColSet"/> class.
        /// 设置列
        /// </summary>
        public TUmColSet()
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
        /// Gets or sets the property value representing column 'TABLE_NAME'.
        /// '页名'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TABLE_NAME'.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TYPE'.
        /// '列类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TYPE'.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TITLE'.
        /// '列名'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TITLE'.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DATA_INDEX'.
        /// '列字段'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DATA_INDEX'.
        /// </value>
        public string DataIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HIDE_IN_SEARCH'.
        /// '是否显示搜索'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HIDE_IN_SEARCH'.
        /// </value>
        public int? HideInSearch { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HIDE_IN_TABLE'.
        /// '是否显示列'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HIDE_IN_TABLE'.
        /// </value>
        public int? HideInTable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FILTERS'.
        /// '筛选条件'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FILTERS'.
        /// </value>
        public string Filters { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SELECTS'.
        /// '下拉条件'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SELECTS'.
        /// </value>
        public string Selects { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WIDTH'.
        /// '宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH'.
        /// </value>
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORT'.
        /// '排序'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT'.
        /// </value>
        public int? Sort { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HIDE_IN_EDIT'.
        /// '是否编辑'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HIDE_IN_EDIT'.
        /// </value>
        public int? HideInEdit { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RULES'.
        /// '是否必填'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RULES'.
        /// </value>
        public int? Rules { get; set; }

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
