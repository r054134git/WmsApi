using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rl_dispatch_rules'.
    /// </summary>
    public partial class TRlDispatchRules
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlDispatchRules"/> class.
        /// 调度规则表
        /// </summary>
        public TRlDispatchRules()
        {
            #region Generated Constructor
            OwnerTRlRegionRanges = new HashSet<TRlRegionRange>();
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
        /// Gets or sets the property value representing column 'NEXT_PROCESS'.
        /// '下一工序'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NEXT_PROCESS'.
        /// </value>
        public string NextProcess { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WIDTH_MIN'.
        /// '宽度最小值'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH_MIN'.
        /// </value>
        public decimal? WidthMin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WIDTH_MAX'.
        /// '宽度最大值'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH_MAX'.
        /// </value>
        public decimal? WidthMax { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'THICK_MIN'.
        /// '厚度最小值'.
        /// </summary>
        /// <value>
        /// The property value representing column 'THICK_MIN'.
        /// </value>
        public decimal? ThickMin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'THICK_MAX'.
        /// '厚度最大值'.
        /// </summary>
        /// <value>
        /// The property value representing column 'THICK_MAX'.
        /// </value>
        public decimal? ThickMax { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="TRlRegionRange" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TRlRegionRange" />.
        /// </value>
        public virtual ICollection<TRlRegionRange> OwnerTRlRegionRanges { get; set; }

        #endregion

    }
}
