using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 汽车跟踪信息表
    /// </summary>
    public partial class TRcTruckReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TruckNo'.
        /// '车牌号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckNo'.
        /// </value>
        public string TruckNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CardNo'.
        /// '卡号'.
        /// </summary>
        /// <value>
        /// The property value for 'CardNo'.
        /// </value>
        public string CardNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MainTruckLoadingNo'.
        /// '主装车清单号'.
        /// </summary>
        /// <value>
        /// The property value for 'MainTruckLoadingNo'.
        /// </value>
        public string MainTruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckBackNo'.
        /// '退货单号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckBackNo'.
        /// </value>
        public string TruckBackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransferNo'.
        /// '库间倒运计划号'.
        /// </summary>
        /// <value>
        /// The property value for 'TransferNo'.
        /// </value>
        public string TransferNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EnterTime'.
        /// '入厂时间'.
        /// </summary>
        /// <value>
        /// The property value for 'EnterTime'.
        /// </value>
        public DateTime? EnterTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ArriveTime'.
        /// '报到时间(进库时间)'.
        /// </summary>
        /// <value>
        /// The property value for 'ArriveTime'.
        /// </value>
        public DateTime? ArriveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InOutType'.
        /// '1：入库，2：出库'.
        /// </summary>
        /// <value>
        /// The property value for 'InOutType'.
        /// </value>
        public int? InOutType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DispatchState'.
        /// '1:接收入厂通知，2、库外等待，3、进入库区，4、进错停车位、5、驶入正确停车位（api判断，正确则是5，否则依然是4，人工干预），6、落杆装车中，7、装车完成，8、抬杆出库，9、出库信息发送至MES'.
        /// </summary>
        /// <value>
        /// The property value for 'DispatchState'.
        /// </value>
        public int? DispatchState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CraneEnabled'.
        /// '行车允许进入 1：允许，0：禁止'.
        /// </summary>
        /// <value>
        /// The property value for 'CraneEnabled'.
        /// </value>
        public int? CraneEnabled { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ParkingEnabled'.
        /// '停车位空闲，允许进入 1：允许，0：禁止'.
        /// </summary>
        /// <value>
        /// The property value for 'ParkingEnabled'.
        /// </value>
        public int? ParkingEnabled { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GateEntryCode'.
        /// '入口道闸code，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'GateEntryCode'.
        /// </value>
        public string GateEntryCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GateEntryId'.
        /// '入口道闸通道GATE_ID，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'GateEntryId'.
        /// </value>
        public string GateEntryId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SortIndex'.
        /// '排序号'.
        /// </summary>
        /// <value>
        /// The property value for 'SortIndex'.
        /// </value>
        public int? SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HasPicked'.
        /// '0:FALSE 1:TRUE  是否挑库'.
        /// </summary>
        /// <value>
        /// The property value for 'HasPicked'.
        /// </value>
        public int? HasPicked { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PositionState'.
        /// '到位状态，0：未到位，1：已到位，2：已离开'.
        /// </summary>
        /// <value>
        /// The property value for 'PositionState'.
        /// </value>
        public int? PositionState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InboundCheckState'.
        /// '入库检查状态，0：无，1：正在检查，2：检查完成'.
        /// </summary>
        /// <value>
        /// The property value for 'InboundCheckState'.
        /// </value>
        public int? InboundCheckState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsPickedCoilConfirmed'.
        /// '挑库钢卷确认状态，0：未确认，1：已确认'.
        /// </summary>
        /// <value>
        /// The property value for 'IsPickedCoilConfirmed'.
        /// </value>
        public int? IsPickedCoilConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsLoadPlansConfirmed'.
        /// '装车计划确认状态，0：未确认，1：已确认'.
        /// </summary>
        /// <value>
        /// The property value for 'IsLoadPlansConfirmed'.
        /// </value>
        public int? IsLoadPlansConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsDriverCheckIn'.
        /// '司机在业务室注册，0：未注册，1：已注册'.
        /// </summary>
        /// <value>
        /// The property value for 'IsDriverCheckIn'.
        /// </value>
        public int? IsDriverCheckIn { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadBussinessNameList'.
        /// '装卷仓库业务库名称列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadBussinessNameList'.
        /// </value>
        public string LoadBussinessNameList { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadBayCodeList'.
        /// '装卷单跨名称列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadBayCodeList'.
        /// </value>
        public string LoadBayCodeList { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FinishBusinessNameList'.
        /// '已完成装车仓库列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'FinishBusinessNameList'.
        /// </value>
        public string FinishBusinessNameList { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FinishBayCodeList'.
        /// '已完成装车跨列表，以逗号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'FinishBayCodeList'.
        /// </value>
        public string FinishBayCodeList { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ParkingNoSuggest'.
        /// '当前推荐的停车位号'.
        /// </summary>
        /// <value>
        /// The property value for 'ParkingNoSuggest'.
        /// </value>
        public string ParkingNoSuggest { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ParkingNoCurrent'.
        /// '当前停车位No，对应No'.
        /// </summary>
        /// <value>
        /// The property value for 'ParkingNoCurrent'.
        /// </value>
        public string ParkingNoCurrent { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckLoadType'.
        /// '汽车发货类型，1：发货单 2：移库单'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckLoadType'.
        /// </value>
        public int? TruckLoadType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsTruckTransfer'.
        /// '汽车发货类型，1：按件发货，2：按量发货，3：废品按量，4：移库'.
        /// </summary>
        /// <value>
        /// The property value for 'IsTruckTransfer'.
        /// </value>
        public int? IsTruckTransfer { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Direction'.
        /// '去向'.
        /// </summary>
        /// <value>
        /// The property value for 'Direction'.
        /// </value>
        public string Direction { get; set; }

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
