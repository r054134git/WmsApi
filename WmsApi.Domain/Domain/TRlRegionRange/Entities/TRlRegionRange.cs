using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rl_region_range'.
    /// </summary>
    public partial class TRlRegionRange
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlRegionRange"/> class.
        /// 区域范围规则表
        /// </summary>
        public TRlRegionRange()
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
        /// Gets or sets the property value representing column 'REGION'.
        /// '区'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REGION'.
        /// </value>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ROW_MIN'.
        /// '最小行'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROW_MIN'.
        /// </value>
        public int? RowMin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ROW_MAX'.
        /// '最大行'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROW_MAX'.
        /// </value>
        public int? RowMax { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COL_MAX'.
        /// '最大列'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COL_MAX'.
        /// </value>
        public int? ColMax { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COL_MIN'.
        /// '最小列'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COL_MIN'.
        /// </value>
        public int? ColMin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORT_INDEX'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT_INDEX'.
        /// </value>
        public int? SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ROW_ORDER_TYPE'.
        /// '1:升序排列 2：降序排列'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROW_ORDER_TYPE'.
        /// </value>
        public int? RowOrderType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COL_ORDER_TYPE'.
        /// '1:升序排列 2：降序排列'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COL_ORDER_TYPE'.
        /// </value>
        public int? ColOrderType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_FILL_FIRST'.
        /// '优先填满'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_FILL_FIRST'.
        /// </value>
        public int? IsFillFirst { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STATION_NO'.
        /// '吊装位编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STATION_NO'.
        /// </value>
        public int? StationNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ALLOW_L2'.
        /// '允许二层'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ALLOW_L2'.
        /// </value>
        public int? AllowL2 { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TRlDispatchRules" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TRlDispatchRules" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TRlDispatchRules OwnerTRlDispatchRules { get; set; }

        #endregion

    }
}
