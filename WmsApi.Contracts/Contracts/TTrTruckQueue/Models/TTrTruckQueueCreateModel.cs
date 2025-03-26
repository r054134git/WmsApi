using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TTrTruckQueueCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TruckCode'.
        /// '车牌号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckCode'.
        /// </value>
        public string TruckCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransType'.
        /// '运输工具类型，0：无，1：汽车，2：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value for 'TransType'.
        /// </value>
        public int TransType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ListNo'.
        /// '单据号，待确认'.
        /// </summary>
        /// <value>
        /// The property value for 'ListNo'.
        /// </value>
        public string ListNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsInFactory'.
        /// '是否在厂'.
        /// </summary>
        /// <value>
        /// The property value for 'IsInFactory'.
        /// </value>
        public int IsInFactory { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryFactoryTime'.
        /// '在厂时间'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryFactoryTime'.
        /// </value>
        public DateTime? EntryFactoryTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DispatchParkingPlaceId'.
        /// '分配的车位id'.
        /// </summary>
        /// <value>
        /// The property value for 'DispatchParkingPlaceId'.
        /// </value>
        public string DispatchParkingPlaceId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DispatchBayId'.
        /// '分配该车辆进入的库区id'.
        /// </summary>
        /// <value>
        /// The property value for 'DispatchBayId'.
        /// </value>
        public string DispatchBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DispatchStepState'.
        /// '待确认'.
        /// </summary>
        /// <value>
        /// The property value for 'DispatchStepState'.
        /// </value>
        public int DispatchStepState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryBayIdList'.
        /// '该车需进入的多个库区列表，以逗号（，）分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryBayIdList'.
        /// </value>
        public string EntryBayIdList { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsInBay'.
        /// '是否在库内，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value for 'IsInBay'.
        /// </value>
        public int IsInBay { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryBayId'.
        /// '当前所在的库区id'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryBayId'.
        /// </value>
        public string EntryBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryBayTime'.
        /// '进入当前库区的时间'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryBayTime'.
        /// </value>
        public DateTime? EntryBayTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Priority'.
        /// '分配车位的优先级，数值越高，优先级越高，默认值100'.
        /// </summary>
        /// <value>
        /// The property value for 'Priority'.
        /// </value>
        public int Priority { get; set; }

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
