using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TEqTrainCarReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CarType'.
        /// '车种，1：卷钢运输车，2：型钢运输车'.
        /// </summary>
        /// <value>
        /// The property value for 'CarType'.
        /// </value>
        public int? CarType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'State'.
        /// '状态，1：在线，2：故修'.
        /// </summary>
        /// <value>
        /// The property value for 'State'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Height'.
        /// '高度'.
        /// </summary>
        /// <value>
        /// The property value for 'Height'.
        /// </value>
        public decimal? Height { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxLoad'.
        /// '载重量'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxLoad'.
        /// </value>
        public decimal? MaxLoad { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SaddleCount'.
        /// '鞍座数量'.
        /// </summary>
        /// <value>
        /// The property value for 'SaddleCount'.
        /// </value>
        public int? SaddleCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

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
