using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_truck_queue'.
    /// </summary>
    public partial class TTrTruckQueue
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTruckQueue"/> class.
        /// 
        /// </summary>
        public TTrTruckQueue()
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
        /// Gets or sets the property value representing column 'TRUCK_CODE'.
        /// '车牌号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_CODE'.
        /// </value>
        public string TruckCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANS_TYPE'.
        /// '运输工具类型，0：无，1：汽车，2：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANS_TYPE'.
        /// </value>
        public int TransType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LIST_NO'.
        /// '单据号，待确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LIST_NO'.
        /// </value>
        public string ListNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_IN_FACTORY'.
        /// '是否在厂'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_IN_FACTORY'.
        /// </value>
        public int IsInFactory { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_FACTORY_TIME'.
        /// '在厂时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_FACTORY_TIME'.
        /// </value>
        public DateTime? EntryFactoryTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPATCH_PARKING_PLACE_ID'.
        /// '分配的车位id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPATCH_PARKING_PLACE_ID'.
        /// </value>
        public string DispatchParkingPlaceId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPATCH_BAY_ID'.
        /// '分配该车辆进入的库区id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPATCH_BAY_ID'.
        /// </value>
        public string DispatchBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPATCH_STEP_STATE'.
        /// '待确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPATCH_STEP_STATE'.
        /// </value>
        public int DispatchStepState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_BAY_ID_LIST'.
        /// '该车需进入的多个库区列表，以逗号（，）分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_BAY_ID_LIST'.
        /// </value>
        public string EntryBayIdList { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_IN_BAY'.
        /// '是否在库内，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_IN_BAY'.
        /// </value>
        public int IsInBay { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_BAY_ID'.
        /// '当前所在的库区id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_BAY_ID'.
        /// </value>
        public string EntryBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_BAY_TIME'.
        /// '进入当前库区的时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_BAY_TIME'.
        /// </value>
        public DateTime? EntryBayTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRIORITY'.
        /// '分配车位的优先级，数值越高，优先级越高，默认值100'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRIORITY'.
        /// </value>
        public int Priority { get; set; }

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
