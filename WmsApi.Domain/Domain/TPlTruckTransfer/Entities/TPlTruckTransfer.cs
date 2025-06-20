using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_truck_transfer'.
    /// </summary>
    public partial class TPlTruckTransfer
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckTransfer"/> class.
        /// 汽车移库单
        /// </summary>
        public TPlTruckTransfer()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// '主键'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OPERATION_MARK'.
        /// 'MES操作标记    N:新增，D:删除、C：生效 F：取消生效'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OPERATION_MARK'.
        /// </value>
        public string OperationMark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANSFER_NO'.
        /// '移库单号(WMS自动补全)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANSFER_NO'.
        /// </value>
        public string TransferNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_NO'.
        /// '订单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NO'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PICK_COUNT'.
        /// '件数(WMS自动补全)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PICK_COUNT'.
        /// </value>
        public int? PickCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT_MAX'.
        /// 'MES汽车载重(kg)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT_MAX'.
        /// </value>
        public int? WeightMax { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CARD_NO'.
        /// 'MES卡号(基本不用)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CARD_NO'.
        /// </value>
        public string CardNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_NO'.
        /// 'MES车牌号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_NO'.
        /// </value>
        public string TruckNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SOURCE_HOUSE'.
        /// 'MES出库库房（P5/P6/P7/P8）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SOURCE_HOUSE'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FAKE_LOADING_NO'.
        /// 'MES虚假装车清单号 （下发车辆信息时用于扫码）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FAKE_LOADING_NO'.
        /// </value>
        public string FakeLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_HOUSE'.
        /// '目的库房(WMS人工补全)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_HOUSE'.
        /// </value>
        public string DestHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SADDLES_COUNT'.
        /// '鞍座数量(WMS人工补全)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SADDLES_COUNT'.
        /// </value>
        public int? SaddlesCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME_TRANSFER'.
        /// '移库单创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME_TRANSFER'.
        /// </value>
        public DateTime? CreateTimeTransfer { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PICK_STATE'.
        /// '移库预挑库状态，0：初始化 1：移库单下发，2：收到应答  3：移库单完成(WMS自动补全) 4:已取消'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PICK_STATE'.
        /// </value>
        public int? PickState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SPECIFY_COIL_NO'.
        /// '是否指定钢卷号。Y：指定材料号，N：不指定'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SPECIFY_COIL_NO'.
        /// </value>
        public string IsSpecifyCoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PREPICK_TYPE'.
        /// '预配数据类型 1=内贸 2=外贸 3=水汽联运'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PREPICK_TYPE'.
        /// </value>
        public int? PrepickType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_DIRECT_TRUCK'.
        /// '是否是直装车辆 1=是'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_DIRECT_TRUCK'.
        /// </value>
        public int? IsDirectTruck { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_REPLACE_COIL'.
        /// '装车前是否换卷 1=更换 '.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_REPLACE_COIL'.
        /// </value>
        public int? IsReplaceCoil { get; set; }

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
