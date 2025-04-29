using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 行车穿行汽车通道的专属通道
    /// </summary>
    public partial class TWhCranePassageUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Code'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Code'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxX'.
        /// '最大坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxX'.
        /// </value>
        public decimal MaxX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinX'.
        /// '最小坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MinX'.
        /// </value>
        public decimal MinX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxY'.
        /// '最大坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxY'.
        /// </value>
        public decimal MaxY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinY'.
        /// '最小坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MinY'.
        /// </value>
        public decimal MinY { get; set; }

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
