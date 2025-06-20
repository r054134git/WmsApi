using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TPlStackTranferReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaId'.
        /// '区id'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaId'.
        /// </value>
        public string AreaId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StartStackId'.
        /// '起点垛id'.
        /// </summary>
        /// <value>
        /// The property value for 'StartStackId'.
        /// </value>
        public string StartStackId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EndStackId'.
        /// '结束垛id'.
        /// </summary>
        /// <value>
        /// The property value for 'EndStackId'.
        /// </value>
        public string EndStackId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StartColId'.
        /// '起点列id'.
        /// </summary>
        /// <value>
        /// The property value for 'StartColId'.
        /// </value>
        public string StartColId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EndColId'.
        /// '终点列id'.
        /// </summary>
        /// <value>
        /// The property value for 'EndColId'.
        /// </value>
        public string EndColId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromPointX'.
        /// '起点X'.
        /// </summary>
        /// <value>
        /// The property value for 'FromPointX'.
        /// </value>
        public decimal? FromPointX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromPointY'.
        /// '起点Y'.
        /// </summary>
        /// <value>
        /// The property value for 'FromPointY'.
        /// </value>
        public decimal? FromPointY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestPointX'.
        /// '终点X'.
        /// </summary>
        /// <value>
        /// The property value for 'DestPointX'.
        /// </value>
        public decimal? DestPointX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestPointY'.
        /// '终点Y'.
        /// </summary>
        /// <value>
        /// The property value for 'DestPointY'.
        /// </value>
        public decimal? DestPointY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Type'.
        /// '计划类型，1：批量倒垛 2：配载备料 3：发货备料'.
        /// </summary>
        /// <value>
        /// The property value for 'Type'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanCount'.
        /// '计划数量'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanCount'.
        /// </value>
        public int PlanCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TodoCount'.
        /// '剩余计划数量'.
        /// </summary>
        /// <value>
        /// The property value for 'TodoCount'.
        /// </value>
        public int TodoCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNoList'.
        /// 'JSON格式字符串，物料号/materialNo'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNoList'.
        /// </value>
        public string MaterialNoList { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNoListAll'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNoListAll'.
        /// </value>
        public string MaterialNoListAll { get; set; }

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
