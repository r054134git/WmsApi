using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_message_send'.
    /// </summary>
    public partial class TTrMessageSend
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrMessageSend"/> class.
        /// 电文发送跟踪
        /// </summary>
        public TTrMessageSend()
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
        /// Gets or sets the property value representing column 'MESSAGE_ID'.
        /// 'WMBM01:钢卷库位变更，WMBM05：发起退库信息'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MESSAGE_ID'.
        /// </value>
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_LOCATION'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_LOCATION'.
        /// </value>
        public string FromLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_LOCATION'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_LOCATION'.
        /// </value>
        public string DestLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BUSINESS_NAME'.
        /// 'P4/P5/P6/P7/P8'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BUSINESS_NAME'.
        /// </value>
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA'.
        /// '1601A'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA'.
        /// </value>
        public string Area { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ROW'.
        /// '1'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROW'.
        /// </value>
        public string Row { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COL'.
        /// '1'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COL'.
        /// </value>
        public string Col { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FLOOR'.
        /// '1/2'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FLOOR'.
        /// </value>
        public string Floor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TYPE'.
        /// '0：入库 1：出库 2：倒垛 3：退库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TYPE'.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OPERATOR'.
        /// '操作员'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OPERATOR'.
        /// </value>
        public string Operator { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RETURN_TYPE'.
        /// 'N：新增 D：删除  退库发起 WMBM05'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RETURN_TYPE'.
        /// </value>
        public string ReturnType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RETURN_REASON'.
        /// '退库描述'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RETURN_REASON'.
        /// </value>
        public string ReturnReason { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '16/17/21-27'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

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
