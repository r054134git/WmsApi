using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_truck'.
    /// </summary>
    public partial class TRcTruck
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTruck"/> class.
        /// 汽车跟踪信息表
        /// </summary>
        public TRcTruck()
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
        /// Gets or sets the property value representing column 'TRUCK_NO'.
        /// '车牌号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_NO'.
        /// </value>
        public string TruckNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CARD_NO'.
        /// '卡号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CARD_NO'.
        /// </value>
        public string CardNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAIN_TRUCK_LOADING_NO'.
        /// '主装车清单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAIN_TRUCK_LOADING_NO'.
        /// </value>
        public string MainTruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_BACK_NO'.
        /// '退货单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_BACK_NO'.
        /// </value>
        public string TruckBackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANSFER_NO'.
        /// '库间倒运计划号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANSFER_NO'.
        /// </value>
        public string TransferNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTER_TIME'.
        /// '入厂时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTER_TIME'.
        /// </value>
        public DateTime? EnterTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ARRIVE_TIME'.
        /// '报到时间(进库时间)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ARRIVE_TIME'.
        /// </value>
        public DateTime? ArriveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_OUT_TYPE'.
        /// '1：入库，2：出库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_OUT_TYPE'.
        /// </value>
        public int? InOutType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPATCH_STATE'.
        /// '1:接收入厂通知，2、库外等待，3、进入库区，4、进错停车位、5、驶入正确停车位（api判断，正确则是5，否则依然是4，人工干预），6、落杆装车中，7、装车完成，8、抬杆出库，9、出库信息发送至MES'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPATCH_STATE'.
        /// </value>
        public int? DispatchState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_ENABLED'.
        /// '行车允许进入 1：允许，0：禁止'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_ENABLED'.
        /// </value>
        public int? CraneEnabled { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PARKING_ENABLED'.
        /// '停车位空闲，允许进入 1：允许，0：禁止'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PARKING_ENABLED'.
        /// </value>
        public int? ParkingEnabled { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GATE_ENTRY_CODE'.
        /// '入口道闸code，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GATE_ENTRY_CODE'.
        /// </value>
        public string GateEntryCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GATE_ENTRY_ID'.
        /// '入口道闸通道GATE_ID，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GATE_ENTRY_ID'.
        /// </value>
        public string GateEntryId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORT_INDEX'.
        /// '排序号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT_INDEX'.
        /// </value>
        public int? SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HAS_PICKED'.
        /// '0:FALSE 1:TRUE  是否挑库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HAS_PICKED'.
        /// </value>
        public int? HasPicked { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POSITION_STATE'.
        /// '到位状态，0：未到位，1：已到位，2：已离开'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POSITION_STATE'.
        /// </value>
        public int? PositionState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'INBOUND_CHECK_STATE'.
        /// '入库检查状态，0：无，1：正在检查，2：检查完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'INBOUND_CHECK_STATE'.
        /// </value>
        public int? InboundCheckState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_PICKED_COIL_CONFIRMED'.
        /// '挑库钢卷确认状态，0：未确认，1：已确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_PICKED_COIL_CONFIRMED'.
        /// </value>
        public int? IsPickedCoilConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_LOAD_PLANS_CONFIRMED'.
        /// '装车计划确认状态，0：未确认，1：已确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_LOAD_PLANS_CONFIRMED'.
        /// </value>
        public int? IsLoadPlansConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_DRIVER_CHECK_IN'.
        /// '司机在业务室注册，0：未注册，1：已注册'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_DRIVER_CHECK_IN'.
        /// </value>
        public int? IsDriverCheckIn { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_BUSSINESS_NAME_LIST'.
        /// '装卷仓库业务库名称列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_BUSSINESS_NAME_LIST'.
        /// </value>
        public string LoadBussinessNameList { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_BAY_CODE_LIST'.
        /// '装卷单跨名称列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_BAY_CODE_LIST'.
        /// </value>
        public string LoadBayCodeList { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FINISH_BUSINESS_NAME_LIST'.
        /// '已完成装车仓库列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FINISH_BUSINESS_NAME_LIST'.
        /// </value>
        public string FinishBusinessNameList { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FINISH_BAY_CODE_LIST'.
        /// '已完成装车跨列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FINISH_BAY_CODE_LIST'.
        /// </value>
        public string FinishBayCodeList { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PARKING_NO_SUGGEST'.
        /// '当前推荐的停车位号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PARKING_NO_SUGGEST'.
        /// </value>
        public string ParkingNoSuggest { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PARKING_NO_CURRENT'.
        /// '当前停车位No，对应No'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PARKING_NO_CURRENT'.
        /// </value>
        public string ParkingNoCurrent { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_LOAD_TYPE'.
        /// '汽车发货类型，1：发货单 2：移库单'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_LOAD_TYPE'.
        /// </value>
        public int? TruckLoadType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_TRUCK_TRANSFER'.
        /// '汽车发货类型，1：按件发货，2：按量发货，3：废品按量，4：移库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_TRUCK_TRANSFER'.
        /// </value>
        public int? IsTruckTransfer { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DIRECTION'.
        /// '去向'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DIRECTION'.
        /// </value>
        public string Direction { get; set; }

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
