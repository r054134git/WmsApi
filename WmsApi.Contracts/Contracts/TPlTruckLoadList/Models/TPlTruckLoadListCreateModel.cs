using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 汽车装车清单
    /// </summary>
    public partial class TPlTruckLoadListCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'OperationMark'.
        /// '操作标记      N:新增,D：删除'.
        /// </summary>
        /// <value>
        /// The property value for 'OperationMark'.
        /// </value>
        public string OperationMark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CardNo'.
        /// '卡号'.
        /// </summary>
        /// <value>
        /// The property value for 'CardNo'.
        /// </value>
        public string CardNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckLoadingNo'.
        /// '装车清单号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckLoadingNo'.
        /// </value>
        public string TruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MainTruckLoadingNo'.
        /// '主装车清单号'.
        /// </summary>
        /// <value>
        /// The property value for 'MainTruckLoadingNo'.
        /// </value>
        public string MainTruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VehicleNo'.
        /// '车辆号'.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleNo'.
        /// </value>
        public string VehicleNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SourceHouse'.
        /// '装车仓库'.
        /// </summary>
        /// <value>
        /// The property value for 'SourceHouse'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DeliveryOrderNo'.
        /// '发货通知单号'.
        /// </summary>
        /// <value>
        /// The property value for 'DeliveryOrderNo'.
        /// </value>
        public string DeliveryOrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ReplyInfo'.
        /// '应答信息'.
        /// </summary>
        /// <value>
        /// The property value for 'ReplyInfo'.
        /// </value>
        public string ReplyInfo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderNo'.
        /// '订单号'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderNo'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DetailNo'.
        /// '明细号'.
        /// </summary>
        /// <value>
        /// The property value for 'DetailNo'.
        /// </value>
        public string DetailNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Count'.
        /// '支数'.
        /// </summary>
        /// <value>
        /// The property value for 'Count'.
        /// </value>
        public string Count { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanOutBoundWeight'.
        /// '计划出库重量'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanOutBoundWeight'.
        /// </value>
        public decimal? PlanOutBoundWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CreateTimeLoadList'.
        /// '接收时间'.
        /// </summary>
        /// <value>
        /// The property value for 'CreateTimeLoadList'.
        /// </value>
        public DateTime? CreateTimeLoadList { get; set; }

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
        /// '报到时间'.
        /// </summary>
        /// <value>
        /// The property value for 'ArriveTime'.
        /// </value>
        public DateTime? ArriveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LeaveTime'.
        /// '离开时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LeaveTime'.
        /// </value>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsFinished'.
        /// '是否完成，0：未完成，1：已完成 2 过期'.
        /// </summary>
        /// <value>
        /// The property value for 'IsFinished'.
        /// </value>
        public int? IsFinished { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Operator'.
        /// '操作人工号  [出库使用]'.
        /// </summary>
        /// <value>
        /// The property value for 'Operator'.
        /// </value>
        public string Operator { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ResolveState'.
        /// '装车单解析状态 0：装车单未配载，1：装车单已配载'.
        /// </summary>
        /// <value>
        /// The property value for 'ResolveState'.
        /// </value>
        public int? ResolveState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AutoPreHint'.
        /// '自动配载提示，一般是错误提示'.
        /// </summary>
        /// <value>
        /// The property value for 'AutoPreHint'.
        /// </value>
        public string AutoPreHint { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注 '.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion

    }
}
