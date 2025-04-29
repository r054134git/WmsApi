using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_eq_crane_weight'.
    /// </summary>
    public partial class TEqCraneWeight
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCraneWeight"/> class.
        /// 
        /// </summary>
        public TEqCraneWeight()
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
        /// Gets or sets the property value representing column 'CRANE_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_ID'.
        /// </value>
        public string CraneId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'METER_UPPER_LIMIT'.
        /// '仪表读数上限'.
        /// </summary>
        /// <value>
        /// The property value representing column 'METER_UPPER_LIMIT'.
        /// </value>
        public decimal MeterUpperLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'METER_LOWER_LIMIT'.
        /// '仪表读数下限'.
        /// </summary>
        /// <value>
        /// The property value representing column 'METER_LOWER_LIMIT'.
        /// </value>
        public decimal MeterLowerLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT_UPPER_LIMIT'.
        /// '重量上限'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT_UPPER_LIMIT'.
        /// </value>
        public decimal WeightUpperLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT_LOWER_LIMIT'.
        /// '重量下限'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT_LOWER_LIMIT'.
        /// </value>
        public decimal WeightLowerLimit { get; set; }

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
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TEqCrane" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TEqCrane" />.
        /// </value>
        /// <seealso cref="CraneId" />
        public virtual TEqCrane CraneTEqCrane { get; set; }

        #endregion

    }
}
