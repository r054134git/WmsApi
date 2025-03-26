using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_train_delivery_pick'.
    /// </summary>
    public partial class TRcTrainDeliveryPick
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTrainDeliveryPick"/> class.
        /// 
        /// </summary>
        public TRcTrainDeliveryPick()
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
        /// '操作标记   N：新增 D：删除'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OPERATION_MARK'.
        /// </value>
        public string OperationMark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DELIVERY_DATE'.
        /// '日期'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DELIVERY_DATE'.
        /// </value>
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SOURCE_HOUSE'.
        /// '发货库房'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SOURCE_HOUSE'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TARGET_HOUSE'.
        /// '目标库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TARGET_HOUSE'.
        /// </value>
        public string TargetHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TARGET_HOUSE_TYPE'.
        /// '目标库类型  (P1) (P2) (P3) (P9) (P1,P3) (P3,P9)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TARGET_HOUSE_TYPE'.
        /// </value>
        public string TargetHouseType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CODE'.
        /// '代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CODE'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COIL_NO'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COIL_NO'.
        /// </value>
        public string CoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COIL_TYPE'.
        /// '钢卷类别 酸洗/平整'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COIL_TYPE'.
        /// </value>
        public string CoilType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRAIN_ID'.
        /// '火车ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRAIN_ID'.
        /// </value>
        public string TrainId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRAIN_NO'.
        /// '火车车次号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRAIN_NO'.
        /// </value>
        public string TrainNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRAIN_LOCATION_NO'.
        /// '火车上的鞍座号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRAIN_LOCATION_NO'.
        /// </value>
        public string TrainLocationNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OPERATOR'.
        /// '操作人  结算人'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OPERATOR'.
        /// </value>
        public string Operator { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STATE'.
        /// '1: 未挑库  2: 已挑库   3: 已完成，4：已过期'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STATE'.
        /// </value>
        public int? State { get; set; }

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
