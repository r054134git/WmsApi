using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 汽车排队信息
    /// </summary>
    public partial class TTrTruckBayQueueReadModel
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
        /// Gets or sets the property value for 'MainLoadingNo'.
        /// '主装车清号'.
        /// </summary>
        /// <value>
        /// The property value for 'MainLoadingNo'.
        /// </value>
        public string MainLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '小库房 16/17'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HouseNo'.
        /// '大库房  P5/P6'.
        /// </summary>
        /// <value>
        /// The property value for 'HouseNo'.
        /// </value>
        public string HouseNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DispatchStepState'.
        /// '当前状态 1=排队中 2=等待入库 3=已入库'.
        /// </summary>
        /// <value>
        /// The property value for 'DispatchStepState'.
        /// </value>
        public int? DispatchStepState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckHeight'.
        /// '车身高度 单位mm'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckHeight'.
        /// </value>
        public int? TruckHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryTime'.
        /// '进厂时间'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryTime'.
        /// </value>
        public DateTime? EntryTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OutTime'.
        /// '出厂时间'.
        /// </summary>
        /// <value>
        /// The property value for 'OutTime'.
        /// </value>
        public DateTime? OutTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryBayTime'.
        /// '进入当前库区的时间'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryBayTime'.
        /// </value>
        public DateTime? EntryBayTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ArriveParkingTime'.
        /// '抵库时间(到达车位时间)'.
        /// </summary>
        /// <value>
        /// The property value for 'ArriveParkingTime'.
        /// </value>
        public DateTime? ArriveParkingTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StartLoadingTime'.
        /// '开始装车时间(扫描完成开始装车的时间)'.
        /// </summary>
        /// <value>
        /// The property value for 'StartLoadingTime'.
        /// </value>
        public DateTime? StartLoadingTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OutBayTime'.
        /// '离库时间'.
        /// </summary>
        /// <value>
        /// The property value for 'OutBayTime'.
        /// </value>
        public DateTime? OutBayTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ConfirmOutTime'.
        /// '确认出库时间'.
        /// </summary>
        /// <value>
        /// The property value for 'ConfirmOutTime'.
        /// </value>
        public DateTime? ConfirmOutTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckType'.
        /// '车辆类型 1= 汽运 2=内倒车'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckType'.
        /// </value>
        public int? TruckType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsMoreBay'.
        /// '是否多库房  0= 否 1=是'.
        /// </summary>
        /// <value>
        /// The property value for 'IsMoreBay'.
        /// </value>
        public int? IsMoreBay { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SortNo'.
        /// '排序号'.
        /// </summary>
        /// <value>
        /// The property value for 'SortNo'.
        /// </value>
        public int? SortNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CallTime'.
        /// '叫号时间'.
        /// </summary>
        /// <value>
        /// The property value for 'CallTime'.
        /// </value>
        public DateTime? CallTime { get; set; }

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
