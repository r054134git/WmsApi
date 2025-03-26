using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库位规则表
    /// </summary>
    public partial class TRcClassStockCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'HouseNo'.
        /// '大库房 P5'.
        /// </summary>
        /// <value>
        /// The property value for 'HouseNo'.
        /// </value>
        public string HouseNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '小库房 16'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SaveTime'.
        /// '生成报表时间'.
        /// </summary>
        /// <value>
        /// The property value for 'SaveTime'.
        /// </value>
        public DateTime? SaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TakeStockCount'.
        /// '接班库存量'.
        /// </summary>
        /// <value>
        /// The property value for 'TakeStockCount'.
        /// </value>
        public int? TakeStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TakeStockWeight'.
        /// '接班库存重量'.
        /// </summary>
        /// <value>
        /// The property value for 'TakeStockWeight'.
        /// </value>
        public decimal? TakeStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HandStockCount'.
        /// '交班库存量'.
        /// </summary>
        /// <value>
        /// The property value for 'HandStockCount'.
        /// </value>
        public int? HandStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HandStockWeight'.
        /// '交班库存重量'.
        /// </summary>
        /// <value>
        /// The property value for 'HandStockWeight'.
        /// </value>
        public decimal? HandStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DeliveryCount'.
        /// '当班发运数量'.
        /// </summary>
        /// <value>
        /// The property value for 'DeliveryCount'.
        /// </value>
        public int? DeliveryCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DeliveryWeight'.
        /// '当班发运重量'.
        /// </summary>
        /// <value>
        /// The property value for 'DeliveryWeight'.
        /// </value>
        public decimal? DeliveryWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HandTakeDiffcount'.
        /// '交接班差异数量'.
        /// </summary>
        /// <value>
        /// The property value for 'HandTakeDiffcount'.
        /// </value>
        public int? HandTakeDiffcount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HandTakeDiffweight'.
        /// '交接班差异重量'.
        /// </summary>
        /// <value>
        /// The property value for 'HandTakeDiffweight'.
        /// </value>
        public decimal? HandTakeDiffweight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MakeStockCount'.
        /// '轧制物料数量'.
        /// </summary>
        /// <value>
        /// The property value for 'MakeStockCount'.
        /// </value>
        public int? MakeStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MakeStockWeight'.
        /// '轧制物料重量'.
        /// </summary>
        /// <value>
        /// The property value for 'MakeStockWeight'.
        /// </value>
        public decimal? MakeStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LockStockCount'.
        /// '被锁定物料数量'.
        /// </summary>
        /// <value>
        /// The property value for 'LockStockCount'.
        /// </value>
        public int? LockStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LockStockWeight'.
        /// '被锁定物料重量'.
        /// </summary>
        /// <value>
        /// The property value for 'LockStockWeight'.
        /// </value>
        public decimal? LockStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PickStockCount'.
        /// '排入运输物料数量'.
        /// </summary>
        /// <value>
        /// The property value for 'PickStockCount'.
        /// </value>
        public int? PickStockCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PickStockWeight'.
        /// '排入运输物料重量'.
        /// </summary>
        /// <value>
        /// The property value for 'PickStockWeight'.
        /// </value>
        public decimal? PickStockWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCplCount'.
        /// '入库物料数量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCplCount'.
        /// </value>
        public int? BayCplCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayPickedCount'.
        /// '出库物料数量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayPickedCount'.
        /// </value>
        public int? BayPickedCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayStackCount'.
        /// '移动物料数量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayStackCount'.
        /// </value>
        public int? BayStackCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayProduceCount'.
        /// '排入生产物料数量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayProduceCount'.
        /// </value>
        public int? BayProduceCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayLbWeight'.
        /// '岚北港流向重量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayLbWeight'.
        /// </value>
        public decimal? BayLbWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayLsWeight'.
        /// '岚山港流向重量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayLsWeight'.
        /// </value>
        public decimal? BayLsWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayLqWeight'.
        /// '岚桥港流向重量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayLqWeight'.
        /// </value>
        public decimal? BayLqWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayLyWeight'.
        /// '连云港流向重量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayLyWeight'.
        /// </value>
        public decimal? BayLyWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayRzWeight'.
        /// '日照港流向重量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayRzWeight'.
        /// </value>
        public decimal? BayRzWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayTrainWeight'.
        /// '火运流向重量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayTrainWeight'.
        /// </value>
        public decimal? BayTrainWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayTruckWeight'.
        /// '汽运流向重量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayTruckWeight'.
        /// </value>
        public decimal? BayTruckWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayNoneWeight'.
        /// '无单重量'.
        /// </summary>
        /// <value>
        /// The property value for 'BayNoneWeight'.
        /// </value>
        public decimal? BayNoneWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CurrentClasses'.
        /// '当前班次 甲/乙/丙'.
        /// </summary>
        /// <value>
        /// The property value for 'CurrentClasses'.
        /// </value>
        public string CurrentClasses { get; set; }

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
