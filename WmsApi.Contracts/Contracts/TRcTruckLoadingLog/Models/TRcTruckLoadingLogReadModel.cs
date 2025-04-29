using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TRcTruckLoadingLogReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '库房'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ParkingPlace'.
        /// '停车位'.
        /// </summary>
        /// <value>
        /// The property value for 'ParkingPlace'.
        /// </value>
        public string ParkingPlace { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Count'.
        /// '装卷数量'.
        /// </summary>
        /// <value>
        /// The property value for 'Count'.
        /// </value>
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckNo'.
        /// '车牌号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckNo'.
        /// </value>
        public string TruckNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MainTruckLoadingNo'.
        /// '主装车单号'.
        /// </summary>
        /// <value>
        /// The property value for 'MainTruckLoadingNo'.
        /// </value>
        public string MainTruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ArriveTime'.
        /// '抵库时间'.
        /// </summary>
        /// <value>
        /// The property value for 'ArriveTime'.
        /// </value>
        public DateTime? ArriveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadingTime'.
        /// '装车时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadingTime'.
        /// </value>
        public DateTime? LoadingTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LeaveTime'.
        /// '离库时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LeaveTime'.
        /// </value>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PrepareTime'.
        /// '准备时长'.
        /// </summary>
        /// <value>
        /// The property value for 'PrepareTime'.
        /// </value>
        public decimal? PrepareTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadTime'.
        /// '装车时长'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadTime'.
        /// </value>
        public decimal? LoadTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FreeTime'.
        /// '空闲时长'.
        /// </summary>
        /// <value>
        /// The property value for 'FreeTime'.
        /// </value>
        public decimal? FreeTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckOutTime'.
        /// '车辆出厂时间'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckOutTime'.
        /// </value>
        public DateTime? TruckOutTime { get; set; }

        #endregion

    }
}
