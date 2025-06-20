using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_cpl'.
    /// </summary>
    public partial class TTrCpl
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCpl"/> class.
        /// 
        /// </summary>
        public TTrCpl()
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
        /// Gets or sets the property value representing column 'CPL_NO'.
        /// '包装线编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CPL_NO'.
        /// </value>
        public int CplNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_TIME'.
        /// 'CPL入口钢卷到达时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_TIME'.
        /// </value>
        public DateTime? EntryTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_INTERVAL'.
        /// 'CPL入口钢卷时间间隔，单位（秒）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_INTERVAL'.
        /// </value>
        public int? EntryInterval { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LEAVE_TIME'.
        /// '钢卷出包装线时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LEAVE_TIME'.
        /// </value>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BUFFER_TOTOAL_COUNT'.
        /// '包装线出口缓存区鞍座总数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BUFFER_TOTOAL_COUNT'.
        /// </value>
        public int BufferTotoalCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BUFFER_USED_COUNT'.
        /// '包装出口缓存区钢卷数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BUFFER_USED_COUNT'.
        /// </value>
        public int BufferUsedCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BUFFER_LAST_USED_NO'.
        /// '上一个出包装线的钢卷所在位置'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BUFFER_LAST_USED_NO'.
        /// </value>
        public int BufferLastUsedNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ADD_PRIORITY'.
        /// '优先级调整值'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ADD_PRIORITY'.
        /// </value>
        public int AddPriority { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ADD_PRIORITY_MANUAL'.
        /// '优先级调整值是否由人工处理，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ADD_PRIORITY_MANUAL'.
        /// </value>
        public int IsAddPriorityManual { get; set; }

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
