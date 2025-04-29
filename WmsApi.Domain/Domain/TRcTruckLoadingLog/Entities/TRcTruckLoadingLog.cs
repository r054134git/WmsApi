using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_truck_loading_log'.
    /// </summary>
    public partial class TRcTruckLoadingLog
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTruckLoadingLog"/> class.
        /// 
        /// </summary>
        public TRcTruckLoadingLog()
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
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '库房'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PARKING_PLACE'.
        /// '停车位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PARKING_PLACE'.
        /// </value>
        public string ParkingPlace { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COUNT'.
        /// '装卷数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COUNT'.
        /// </value>
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_NO'.
        /// '车牌号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_NO'.
        /// </value>
        public string TruckNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAIN_TRUCK_LOADING_NO'.
        /// '主装车单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAIN_TRUCK_LOADING_NO'.
        /// </value>
        public string MainTruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ARRIVE_TIME'.
        /// '抵库时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ARRIVE_TIME'.
        /// </value>
        public DateTime? ArriveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOADING_TIME'.
        /// '装车时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOADING_TIME'.
        /// </value>
        public DateTime? LoadingTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LEAVE_TIME'.
        /// '离库时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LEAVE_TIME'.
        /// </value>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PREPARE_TIME'.
        /// '准备时长'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PREPARE_TIME'.
        /// </value>
        public decimal? PrepareTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_TIME'.
        /// '装车时长'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_TIME'.
        /// </value>
        public decimal? LoadTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FREE_TIME'.
        /// '空闲时长'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FREE_TIME'.
        /// </value>
        public decimal? FreeTime { get; set; }

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

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_OUT_TIME'.
        /// '车辆出厂时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_OUT_TIME'.
        /// </value>
        public DateTime? TruckOutTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
