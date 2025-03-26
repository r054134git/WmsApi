using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_wh_truck_parking_place'.
    /// </summary>
    public partial class TWhTruckParkingPlace
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTruckParkingPlace"/> class.
        /// 
        /// </summary>
        public TWhTruckParkingPlace()
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
        /// Gets or sets the property value representing column 'NAME'.
        /// '车位名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CODE'.
        /// '唯一代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CODE'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_X'.
        /// '最大坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_X'.
        /// </value>
        public decimal MaxX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_X'.
        /// '最小坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_X'.
        /// </value>
        public decimal MinX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_Y'.
        /// '最大坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_Y'.
        /// </value>
        public decimal MaxY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_Y'.
        /// '最小坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_Y'.
        /// </value>
        public decimal MinY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TOTAL_PARKING'.
        /// '车位可停车的总数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TOTAL_PARKING'.
        /// </value>
        public int TotalParking { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_AVOID_TYPE'.
        /// '行车对车位的避让类型，0：不避让，1：避让车位区域，2：避让车位所属车道区域'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_AVOID_TYPE'.
        /// </value>
        public int? CraneAvoidType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '父id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '跨 code'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

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
