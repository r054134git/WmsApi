using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TTrParkingPlaceUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'ParkingPlaceId'.
        /// '车位ID'.
        /// </summary>
        /// <value>
        /// The property value for 'ParkingPlaceId'.
        /// </value>
        public string ParkingPlaceId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '跨编码'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ParkingPlaceName'.
        /// '车位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'ParkingPlaceName'.
        /// </value>
        public string ParkingPlaceName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsUsing'.
        /// '车位是否在使用，0：空闲，1：占用'.
        /// </summary>
        /// <value>
        /// The property value for 'IsUsing'.
        /// </value>
        public int IsUsing { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransType'.
        /// '占用车位的运输工具类型，0：无，1：汽车，2：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value for 'TransType'.
        /// </value>
        public int TransType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransCode'.
        /// '占用车位的运输工具代码，车牌或电瓶车号'.
        /// </summary>
        /// <value>
        /// The property value for 'TransCode'.
        /// </value>
        public string TransCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CandidateTruck'.
        /// '车位等候车辆，用逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'CandidateTruck'.
        /// </value>
        public string CandidateTruck { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GateId'.
        /// '车位道闸ID  大华内部'.
        /// </summary>
        /// <value>
        /// The property value for 'GateId'.
        /// </value>
        public string GateId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GateState'.
        /// '0：关闭（落杆），1：开启（抬杆）'.
        /// </summary>
        /// <value>
        /// The property value for 'GateState'.
        /// </value>
        public int GateState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DispatchStepState'.
        /// '汽车装卸流程状态，0：无，1：待确认'.
        /// </summary>
        /// <value>
        /// The property value for 'DispatchStepState'.
        /// </value>
        public int? DispatchStepState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HeadCenterX'.
        /// '车头中心点X'.
        /// </summary>
        /// <value>
        /// The property value for 'HeadCenterX'.
        /// </value>
        public int? HeadCenterX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HeadCenterY'.
        /// '车头中心点Y'.
        /// </summary>
        /// <value>
        /// The property value for 'HeadCenterY'.
        /// </value>
        public int? HeadCenterY { get; set; }

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
