using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_delivery_plan'.
    /// </summary>
    public partial class TPlDeliveryPlan
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlDeliveryPlan"/> class.
        /// MES下发的发运计划
        /// </summary>
        public TPlDeliveryPlan()
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
        /// Gets or sets the property value representing column 'HOUSE'.
        /// '库房'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOUSE'.
        /// </value>
        public string House { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_NO'.
        /// '订单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NO'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_NUM'.
        /// '计划数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_NUM'.
        /// </value>
        public int? PlanNum { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_WEIGHT'.
        /// '计划重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_WEIGHT'.
        /// </value>
        public decimal? PlanWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_DATE'.
        /// '计划日期'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_DATE'.
        /// </value>
        public string PlanDate { get; set; }

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
