using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_truck_queue_in_bay_shift'.
    /// </summary>
    public partial class TPlTruckQueueInBayShift
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckQueueInBayShift"/> class.
        /// 库内排队信息，进库车辆信息有变更时发送（倒运）
        /// </summary>
        public TPlTruckQueueInBayShift()
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
        /// Gets or sets the property value representing column 'OUT_HOUSE'.
        /// '出库库房'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OUT_HOUSE'.
        /// </value>
        public string OutHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CARD_NO'.
        /// '卡号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CARD_NO'.
        /// </value>
        public string CardNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_NO'.
        /// '车辆号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_NO'.
        /// </value>
        public string VehicleNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ARRIVE_NO'.
        /// '报道号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ARRIVE_NO'.
        /// </value>
        public string ArriveNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_LOADING_NO'.
        /// '装车清单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_LOADING_NO'.
        /// </value>
        public string TruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_LOAD'.
        /// '载重'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_LOAD'.
        /// </value>
        public decimal? TruckLoad { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_HOUSE'.
        /// '入库库房'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_HOUSE'.
        /// </value>
        public string EntryHouse { get; set; }

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
        /// '明细号（订单项次）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DETAIL_NO'.
        /// </value>
        public string DetailNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NO'.
        /// '材料号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NO'.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ITEM_COUNT'.
        /// '计划件数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ITEM_COUNT'.
        /// </value>
        public decimal? ItemCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT_TOTAL'.
        /// '计划重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT_TOTAL'.
        /// </value>
        public decimal? WeightTotal { get; set; }

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
