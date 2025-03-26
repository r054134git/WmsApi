using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TWhTruckParkingPlaceUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '车位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Code'.
        /// '唯一代码'.
        /// </summary>
        /// <value>
        /// The property value for 'Code'.
        /// </value>
        public string Code { get; set; }

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
        /// Gets or sets the property value for 'TotalParking'.
        /// '车位可停车的总数'.
        /// </summary>
        /// <value>
        /// The property value for 'TotalParking'.
        /// </value>
        public int TotalParking { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CraneAvoidType'.
        /// '行车对车位的避让类型，0：不避让，1：避让车位区域，2：避让车位所属车道区域'.
        /// </summary>
        /// <value>
        /// The property value for 'CraneAvoidType'.
        /// </value>
        public int? CraneAvoidType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '父id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '跨 code'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

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
