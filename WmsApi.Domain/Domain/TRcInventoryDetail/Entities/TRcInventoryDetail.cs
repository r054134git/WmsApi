using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_inventory_detail'.
    /// </summary>
    public partial class TRcInventoryDetail
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcInventoryDetail"/> class.
        /// 
        /// </summary>
        public TRcInventoryDetail()
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
        /// Gets or sets the property value representing column 'PLAN_ID'.
        /// '盘库批次'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_ID'.
        /// </value>
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BUNDLE_NO'.
        /// '捆包号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BUNDLE_NO'.
        /// </value>
        public string BundleNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SCAN'.
        /// '是否扫描，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SCAN'.
        /// </value>
        public int? IsScan { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_WMS'.
        /// '是否在库，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_WMS'.
        /// </value>
        public int? IsWms { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WMS_LOCATION_NAME'.
        /// '系统内库位号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WMS_LOCATION_NAME'.
        /// </value>
        public string WmsLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'USER_LOCATION_NAME'.
        /// '用户输入库位号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'USER_LOCATION_NAME'.
        /// </value>
        public string UserLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SYSTEM_COMMENT'.
        /// '系统分析备注'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SYSTEM_COMMENT'.
        /// </value>
        public string SystemComment { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TRcInventory" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TRcInventory" />.
        /// </value>
        /// <seealso cref="PlanId" />
        public virtual TRcInventory PlanTRcInventory { get; set; }

        #endregion

    }
}
