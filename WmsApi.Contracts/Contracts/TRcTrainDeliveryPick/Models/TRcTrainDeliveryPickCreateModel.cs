using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TRcTrainDeliveryPickCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'OperationMark'.
        /// '操作标记   N：新增 D：删除'.
        /// </summary>
        /// <value>
        /// The property value for 'OperationMark'.
        /// </value>
        public string OperationMark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DeliveryDate'.
        /// '日期'.
        /// </summary>
        /// <value>
        /// The property value for 'DeliveryDate'.
        /// </value>
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SourceHouse'.
        /// '发货库房'.
        /// </summary>
        /// <value>
        /// The property value for 'SourceHouse'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TargetHouse'.
        /// '目标库'.
        /// </summary>
        /// <value>
        /// The property value for 'TargetHouse'.
        /// </value>
        public string TargetHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TargetHouseType'.
        /// '目标库类型  (P1) (P2) (P3) (P9) (P1,P3) (P3,P9)'.
        /// </summary>
        /// <value>
        /// The property value for 'TargetHouseType'.
        /// </value>
        public string TargetHouseType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Code'.
        /// '代码'.
        /// </summary>
        /// <value>
        /// The property value for 'Code'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CoilNo'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'CoilNo'.
        /// </value>
        public string CoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CoilType'.
        /// '钢卷类别 酸洗/平整'.
        /// </summary>
        /// <value>
        /// The property value for 'CoilType'.
        /// </value>
        public string CoilType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrainId'.
        /// '火车ID'.
        /// </summary>
        /// <value>
        /// The property value for 'TrainId'.
        /// </value>
        public string TrainId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrainNo'.
        /// '火车车次号'.
        /// </summary>
        /// <value>
        /// The property value for 'TrainNo'.
        /// </value>
        public string TrainNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrainLocationNo'.
        /// '火车上的鞍座号'.
        /// </summary>
        /// <value>
        /// The property value for 'TrainLocationNo'.
        /// </value>
        public string TrainLocationNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Operator'.
        /// '操作人  结算人'.
        /// </summary>
        /// <value>
        /// The property value for 'Operator'.
        /// </value>
        public string Operator { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'State'.
        /// '1: 未挑库  2: 已挑库   3: 已完成，4：已过期'.
        /// </summary>
        /// <value>
        /// The property value for 'State'.
        /// </value>
        public int? State { get; set; }

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
