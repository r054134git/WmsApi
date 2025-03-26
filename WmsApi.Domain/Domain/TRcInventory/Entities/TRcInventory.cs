using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_inventory'.
    /// </summary>
    public partial class TRcInventory
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcInventory"/> class.
        /// 
        /// </summary>
        public TRcInventory()
        {
            #region Generated Constructor
            PlanTRcInventoryDetails = new HashSet<TRcInventoryDetail>();
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
        /// Gets or sets the property value representing column 'PLAN_NO'.
        /// '计划批次号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_NO'.
        /// </value>
        public string PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'USER_ACCOUNT'.
        /// '用户账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'USER_ACCOUNT'.
        /// </value>
        public string UserAccount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'USER_NAME'.
        /// '姓名'.
        /// </summary>
        /// <value>
        /// The property value representing column 'USER_NAME'.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '库编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCAN_COUNT'.
        /// '扫描总数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCAN_COUNT'.
        /// </value>
        public int ScanCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WMS_COUNT'.
        /// '系统在库总数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WMS_COUNT'.
        /// </value>
        public int WmsCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCAN_NOT_IN_WMS_COUNT'.
        /// '扫描不在库个数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCAN_NOT_IN_WMS_COUNT'.
        /// </value>
        public int ScanNotInWmsCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCAN_IN_WMS_COUNT'.
        /// '扫描在库个数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCAN_IN_WMS_COUNT'.
        /// </value>
        public int ScanInWmsCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WMS_NOT_IN_SCAN_COUNT'.
        /// '在库未扫描个数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WMS_NOT_IN_SCAN_COUNT'.
        /// </value>
        public int WmsNotInScanCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_FINISHED'.
        /// '0：未完成，1：已完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_FINISHED'.
        /// </value>
        public int IsFinished { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="TRcInventoryDetail" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TRcInventoryDetail" />.
        /// </value>
        public virtual ICollection<TRcInventoryDetail> PlanTRcInventoryDetails { get; set; }

        #endregion

    }
}
