using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// MES下发的发运计划
    /// </summary>
    public partial class TPlDeliveryPlanCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'House'.
        /// '库房'.
        /// </summary>
        /// <value>
        /// The property value for 'House'.
        /// </value>
        public string House { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderNo'.
        /// '订单号'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderNo'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanNum'.
        /// '计划数量'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanNum'.
        /// </value>
        public int? PlanNum { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanWeight'.
        /// '计划重量'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanWeight'.
        /// </value>
        public decimal? PlanWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanDate'.
        /// '计划日期'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanDate'.
        /// </value>
        public string PlanDate { get; set; }

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
