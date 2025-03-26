using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库区安全围栏区域
    /// </summary>
    public partial class TEqFenceAreaReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// 'BAYID'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinX'.
        /// '最小坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MinX'.
        /// </value>
        public decimal MinX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxX'.
        /// '最大坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxX'.
        /// </value>
        public decimal MaxX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinY'.
        /// '最小坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MinY'.
        /// </value>
        public decimal MinY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxY'.
        /// '最大坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxY'.
        /// </value>
        public decimal MaxY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LinkTargetType'.
        /// '关联的目标设备类型，0：无，1：行车，2：过跨车'.
        /// </summary>
        /// <value>
        /// The property value for 'LinkTargetType'.
        /// </value>
        public int? LinkTargetType { get; set; }

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
