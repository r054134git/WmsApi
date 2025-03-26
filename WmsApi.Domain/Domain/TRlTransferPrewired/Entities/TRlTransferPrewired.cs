using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rl_transfer_prewired'.
    /// </summary>
    public partial class TRlTransferPrewired
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlTransferPrewired"/> class.
        /// 库位规则表
        /// </summary>
        public TRlTransferPrewired()
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
        /// Gets or sets the property value representing column 'STOWAGE_TYPE'.
        /// '配载类型 1=内贸 2=外贸 3=水汽联运'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STOWAGE_TYPE'.
        /// </value>
        public int? StowageType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_DISTRIBUTION_SHIP'.
        /// '是否配船 0=无 1=配船 2=非配船'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_DISTRIBUTION_SHIP'.
        /// </value>
        public int? IsDistributionShip { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SPEC'.
        /// '是否限制规格 0=不限 1=限制'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SPEC'.
        /// </value>
        public int? IsSpec { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PORT_LOT_NUMBER'.
        /// '支持的港口批号 数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PORT_LOT_NUMBER'.
        /// </value>
        public int? PortLotNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_NO'.
        /// '排序号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NO'.
        /// </value>
        public int? OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT_LIMIT'.
        /// '允许配载的最大重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT_LIMIT'.
        /// </value>
        public int? WeightLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NUMBER_LIMIT'.
        /// '允许配载的最大件数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NUMBER_LIMIT'.
        /// </value>
        public int? NumberLimit { get; set; }

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
