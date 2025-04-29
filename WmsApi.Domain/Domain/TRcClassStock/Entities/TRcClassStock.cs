using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_class_stock'.
    /// </summary>
    public partial class TRcClassStock
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcClassStock"/> class.
        /// 库位规则表
        /// </summary>
        public TRcClassStock()
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
        /// Gets or sets the property value representing column 'HOUSE_NO'.
        /// '大库房 P5'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOUSE_NO'.
        /// </value>
        public string HouseNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '小库房 16'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SAVE_TIME'.
        /// '生成报表时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SAVE_TIME'.
        /// </value>
        public DateTime? SaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TAKE_STOCK_COUNT'.
        /// '接班库存量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TAKE_STOCK_COUNT'.
        /// </value>
        public int? TakeStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TAKE_STOCK_WEIGHT'.
        /// '接班库存重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TAKE_STOCK_WEIGHT'.
        /// </value>
        public decimal? TakeStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HAND_STOCK_COUNT'.
        /// '交班库存量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HAND_STOCK_COUNT'.
        /// </value>
        public int? HandStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HAND_STOCK_WEIGHT'.
        /// '交班库存重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HAND_STOCK_WEIGHT'.
        /// </value>
        public decimal? HandStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DELIVERY_COUNT'.
        /// '当班发运数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DELIVERY_COUNT'.
        /// </value>
        public int? DeliveryCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DELIVERY_WEIGHT'.
        /// '当班发运重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DELIVERY_WEIGHT'.
        /// </value>
        public decimal? DeliveryWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HAND_TAKE_DIFFCOUNT'.
        /// '交接班差异数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HAND_TAKE_DIFFCOUNT'.
        /// </value>
        public int? HandTakeDiffcount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HAND_TAKE_DIFFWEIGHT'.
        /// '交接班差异重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HAND_TAKE_DIFFWEIGHT'.
        /// </value>
        public decimal? HandTakeDiffweight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAKE_STOCK_COUNT'.
        /// '轧制物料数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAKE_STOCK_COUNT'.
        /// </value>
        public int? MakeStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAKE_STOCK_WEIGHT'.
        /// '轧制物料重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAKE_STOCK_WEIGHT'.
        /// </value>
        public decimal? MakeStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCK_STOCK_COUNT'.
        /// '被锁定物料数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCK_STOCK_COUNT'.
        /// </value>
        public int? LockStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCK_STOCK_WEIGHT'.
        /// '被锁定物料重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCK_STOCK_WEIGHT'.
        /// </value>
        public decimal? LockStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PICK_STOCK_COUNT'.
        /// '排入运输物料数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PICK_STOCK_COUNT'.
        /// </value>
        public int? PickStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PICK_STOCK_WEIGHT'.
        /// '排入运输物料重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PICK_STOCK_WEIGHT'.
        /// </value>
        public decimal? PickStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CPL_COUNT'.
        /// '入库物料数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CPL_COUNT'.
        /// </value>
        public int? BayCplCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_PICKED_COUNT'.
        /// '出库物料数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_PICKED_COUNT'.
        /// </value>
        public int? BayPickedCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_STACK_COUNT'.
        /// '移动物料数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_STACK_COUNT'.
        /// </value>
        public int? BayStackCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_PRODUCE_COUNT'.
        /// '排入生产物料数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_PRODUCE_COUNT'.
        /// </value>
        public int? BayProduceCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_LB_WEIGHT'.
        /// '岚北港流向重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_LB_WEIGHT'.
        /// </value>
        public decimal? BayLbWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_LS_WEIGHT'.
        /// '岚山港流向重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_LS_WEIGHT'.
        /// </value>
        public decimal? BayLsWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_LQ_WEIGHT'.
        /// '岚桥港流向重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_LQ_WEIGHT'.
        /// </value>
        public decimal? BayLqWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_LY_WEIGHT'.
        /// '连云港流向重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_LY_WEIGHT'.
        /// </value>
        public decimal? BayLyWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_RZ_WEIGHT'.
        /// '日照港流向重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_RZ_WEIGHT'.
        /// </value>
        public decimal? BayRzWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_TRAIN_WEIGHT'.
        /// '火运流向重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_TRAIN_WEIGHT'.
        /// </value>
        public decimal? BayTrainWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_TRUCK_WEIGHT'.
        /// '汽运流向重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_TRUCK_WEIGHT'.
        /// </value>
        public decimal? BayTruckWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_NONE_WEIGHT'.
        /// '无单重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_NONE_WEIGHT'.
        /// </value>
        public decimal? BayNoneWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CURRENT_CLASSES'.
        /// '当前班次 甲/乙/丙'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CURRENT_CLASSES'.
        /// </value>
        public string CurrentClasses { get; set; }

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
