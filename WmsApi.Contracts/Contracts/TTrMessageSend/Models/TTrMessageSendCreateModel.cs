using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 电文发送跟踪
    /// </summary>
    public partial class TTrMessageSendCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'MessageId'.
        /// 'WMBM01:钢卷库位变更，WMBM05：发起退库信息'.
        /// </summary>
        /// <value>
        /// The property value for 'MessageId'.
        /// </value>
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromLocation'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'FromLocation'.
        /// </value>
        public string FromLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestLocation'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DestLocation'.
        /// </value>
        public string DestLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BusinessName'.
        /// 'P4/P5/P6/P7/P8'.
        /// </summary>
        /// <value>
        /// The property value for 'BusinessName'.
        /// </value>
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Area'.
        /// '1601A'.
        /// </summary>
        /// <value>
        /// The property value for 'Area'.
        /// </value>
        public string Area { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Row'.
        /// '1'.
        /// </summary>
        /// <value>
        /// The property value for 'Row'.
        /// </value>
        public string Row { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Col'.
        /// '1'.
        /// </summary>
        /// <value>
        /// The property value for 'Col'.
        /// </value>
        public string Col { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Floor'.
        /// '1/2'.
        /// </summary>
        /// <value>
        /// The property value for 'Floor'.
        /// </value>
        public string Floor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Type'.
        /// '0：入库 1：出库 2：倒垛 3：退库'.
        /// </summary>
        /// <value>
        /// The property value for 'Type'.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Operator'.
        /// '操作员'.
        /// </summary>
        /// <value>
        /// The property value for 'Operator'.
        /// </value>
        public string Operator { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ReturnType'.
        /// 'N：新增 D：删除  退库发起 WMBM05'.
        /// </summary>
        /// <value>
        /// The property value for 'ReturnType'.
        /// </value>
        public string ReturnType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ReturnReason'.
        /// '退库描述'.
        /// </summary>
        /// <value>
        /// The property value for 'ReturnReason'.
        /// </value>
        public string ReturnReason { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '16/17/21-27'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

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
