using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TTrCplReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CplNo'.
        /// '包装线编号'.
        /// </summary>
        /// <value>
        /// The property value for 'CplNo'.
        /// </value>
        public int CplNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryTime'.
        /// 'CPL入口钢卷到达时间'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryTime'.
        /// </value>
        public DateTime? EntryTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryInterval'.
        /// 'CPL入口钢卷时间间隔，单位（秒）'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryInterval'.
        /// </value>
        public int? EntryInterval { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LeaveTime'.
        /// '钢卷出包装线时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LeaveTime'.
        /// </value>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BufferTotoalCount'.
        /// '包装线出口缓存区鞍座总数'.
        /// </summary>
        /// <value>
        /// The property value for 'BufferTotoalCount'.
        /// </value>
        public int BufferTotoalCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BufferUsedCount'.
        /// '包装出口缓存区钢卷数量'.
        /// </summary>
        /// <value>
        /// The property value for 'BufferUsedCount'.
        /// </value>
        public int BufferUsedCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BufferLastUsedNo'.
        /// '上一个出包装线的钢卷所在位置'.
        /// </summary>
        /// <value>
        /// The property value for 'BufferLastUsedNo'.
        /// </value>
        public int BufferLastUsedNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AddPriority'.
        /// '优先级调整值'.
        /// </summary>
        /// <value>
        /// The property value for 'AddPriority'.
        /// </value>
        public int AddPriority { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsAddPriorityManual'.
        /// '优先级调整值是否由人工处理，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value for 'IsAddPriorityManual'.
        /// </value>
        public int IsAddPriorityManual { get; set; }

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
