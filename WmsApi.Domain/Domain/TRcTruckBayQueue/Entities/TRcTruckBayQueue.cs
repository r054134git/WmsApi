using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_truck_bay_queue'.
    /// </summary>
    public partial class TRcTruckBayQueue
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTruckBayQueue"/> class.
        /// 
        /// </summary>
        public TRcTruckBayQueue()
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
        /// Gets or sets the property value representing column 'MAIN_LOADING_NO'.
        /// '主装车清号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAIN_LOADING_NO'.
        /// </value>
        public string MainLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '小库房 16/17'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOUSE_NO'.
        /// '大库房  P5/P6'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOUSE_NO'.
        /// </value>
        public string HouseNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPATCH_STEP_STATE'.
        /// '当前状态 1=排队中 2=等待入库 3=已入库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPATCH_STEP_STATE'.
        /// </value>
        public int? DispatchStepState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_HEIGHT'.
        /// '车身高度 单位mm'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_HEIGHT'.
        /// </value>
        public int? TruckHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_TIME'.
        /// '进厂时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_TIME'.
        /// </value>
        public DateTime? EntryTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OUT_TIME'.
        /// '出厂时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OUT_TIME'.
        /// </value>
        public DateTime? OutTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_BAY_TIME'.
        /// '进入当前库区的时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_BAY_TIME'.
        /// </value>
        public DateTime? EntryBayTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ARRIVE_PARKING_TIME'.
        /// '抵库时间(到达车位时间)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ARRIVE_PARKING_TIME'.
        /// </value>
        public DateTime? ArriveParkingTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'START_LOADING_TIME'.
        /// '开始装车时间(扫描完成开始装车的时间)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'START_LOADING_TIME'.
        /// </value>
        public DateTime? StartLoadingTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OUT_BAY_TIME'.
        /// '离开当前库区的时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OUT_BAY_TIME'.
        /// </value>
        public DateTime? OutBayTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CONFIRM_OUT_TIME'.
        /// '确认出库时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CONFIRM_OUT_TIME'.
        /// </value>
        public DateTime? ConfirmOutTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_TYPE'.
        /// '车辆类型 1= 汽运 2=内倒车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_TYPE'.
        /// </value>
        public int? TruckType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_MORE_BAY'.
        /// '是否多库房  0= 否 1=是'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_MORE_BAY'.
        /// </value>
        public int? IsMoreBay { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORT_NO'.
        /// '排序号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT_NO'.
        /// </value>
        public int? SortNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CALL_TIME'.
        /// '叫号时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CALL_TIME'.
        /// </value>
        public DateTime? CallTime { get; set; }

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
