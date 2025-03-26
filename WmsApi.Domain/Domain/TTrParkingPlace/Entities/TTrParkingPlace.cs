using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_parking_place'.
    /// </summary>
    public partial class TTrParkingPlace
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrParkingPlace"/> class.
        /// 
        /// </summary>
        public TTrParkingPlace()
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
        /// Gets or sets the property value representing column 'PARKING_PLACE_ID'.
        /// '车位ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PARKING_PLACE_ID'.
        /// </value>
        public string ParkingPlaceId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '跨编码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PARKING_PLACE_NAME'.
        /// '车位名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PARKING_PLACE_NAME'.
        /// </value>
        public string ParkingPlaceName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_USING'.
        /// '车位是否在使用，0：空闲，1：占用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_USING'.
        /// </value>
        public int IsUsing { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANS_TYPE'.
        /// '占用车位的运输工具类型，0：无，1：汽车，2：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANS_TYPE'.
        /// </value>
        public int TransType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANS_CODE'.
        /// '占用车位的运输工具代码，车牌或电瓶车号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANS_CODE'.
        /// </value>
        public string TransCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CANDIDATE_TRUCK'.
        /// '车位等候车辆，用逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CANDIDATE_TRUCK'.
        /// </value>
        public string CandidateTruck { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GATE_ID'.
        /// '车位道闸ID  大华内部'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GATE_ID'.
        /// </value>
        public string GateId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GATE_STATE'.
        /// '0：关闭（落杆），1：开启（抬杆）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GATE_STATE'.
        /// </value>
        public int GateState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPATCH_STEP_STATE'.
        /// '汽车装卸流程状态，0：无，1：待确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPATCH_STEP_STATE'.
        /// </value>
        public int? DispatchStepState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HEAD_CENTER_X'.
        /// '车头中心点X'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HEAD_CENTER_X'.
        /// </value>
        public int? HeadCenterX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HEAD_CENTER_Y'.
        /// '车头中心点Y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HEAD_CENTER_Y'.
        /// </value>
        public int? HeadCenterY { get; set; }

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
