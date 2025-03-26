using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 汽车退货计划
    /// </summary>
    public partial class TPlTruckBackUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TruckBackNo'.
        /// '退货单号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckBackNo'.
        /// </value>
        public string TruckBackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// 'JSON格式字符串，钢卷号/materialNo'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckNo'.
        /// '退货车号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckNo'.
        /// </value>
        public string TruckNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SuggestBay'.
        /// '推荐库房'.
        /// </summary>
        /// <value>
        /// The property value for 'SuggestBay'.
        /// </value>
        public string SuggestBay { get; set; }

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
