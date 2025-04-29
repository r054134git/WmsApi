using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_truck_load_list'.
    /// </summary>
    public partial class TPlTruckLoadList
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckLoadList"/> class.
        /// 汽车装车清单
        /// </summary>
        public TPlTruckLoadList()
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
        /// Gets or sets the property value representing column 'OPERATION_MARK'.
        /// '操作标记      N:新增,D：删除'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OPERATION_MARK'.
        /// </value>
        public string OperationMark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CARD_NO'.
        /// '卡号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CARD_NO'.
        /// </value>
        public string CardNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_LOADING_NO'.
        /// '装车清单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_LOADING_NO'.
        /// </value>
        public string TruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAIN_TRUCK_LOADING_NO'.
        /// '主装车清单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAIN_TRUCK_LOADING_NO'.
        /// </value>
        public string MainTruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_NO'.
        /// '车辆号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_NO'.
        /// </value>
        public string VehicleNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SOURCE_HOUSE'.
        /// '装车仓库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SOURCE_HOUSE'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DELIVERY_ORDER_NO'.
        /// '发货通知单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DELIVERY_ORDER_NO'.
        /// </value>
        public string DeliveryOrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REPLY_INFO'.
        /// '应答信息'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REPLY_INFO'.
        /// </value>
        public string ReplyInfo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_NO'.
        /// '订单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NO'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DETAIL_NO'.
        /// '明细号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DETAIL_NO'.
        /// </value>
        public string DetailNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COUNT'.
        /// '支数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COUNT'.
        /// </value>
        public string Count { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_OUT_BOUND_WEIGHT'.
        /// '计划出库重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_OUT_BOUND_WEIGHT'.
        /// </value>
        public decimal? PlanOutBoundWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME_LOAD_LIST'.
        /// '接收时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME_LOAD_LIST'.
        /// </value>
        public DateTime? CreateTimeLoadList { get; set; }

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
        /// '报到时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ARRIVE_TIME'.
        /// </value>
        public DateTime? ArriveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LEAVE_TIME'.
        /// '离开时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LEAVE_TIME'.
        /// </value>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_FINISHED'.
        /// '是否完成，0：未完成，1：已完成 2 过期'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_FINISHED'.
        /// </value>
        public int? IsFinished { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OPERATOR'.
        /// '操作人工号  [出库使用]'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OPERATOR'.
        /// </value>
        public string Operator { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RESOLVE_STATE'.
        /// '装车单解析状态 0：装车单未配载，1：装车单已配载'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RESOLVE_STATE'.
        /// </value>
        public int? ResolveState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AUTO_PRE_HINT'.
        /// '自动配载提示，一般是错误提示'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AUTO_PRE_HINT'.
        /// </value>
        public string AutoPreHint { get; set; }

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
        /// '备注 '.
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
