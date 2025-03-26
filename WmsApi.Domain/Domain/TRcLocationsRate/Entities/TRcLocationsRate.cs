using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_locations_rate'.
    /// </summary>
    public partial class TRcLocationsRate
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLocationsRate"/> class.
        /// 
        /// </summary>
        public TRcLocationsRate()
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
        /// Gets or sets the property value representing column 'DT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DT'.
        /// </value>
        public DateTime Dt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COUNT_COILS_FLOOR1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'COUNT_COILS_FLOOR1'.
        /// </value>
        public int CountCoilsFloor1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COUNT_LOCATIONS_FLOOR1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'COUNT_LOCATIONS_FLOOR1'.
        /// </value>
        public int CountLocationsFloor1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COUNT_COILS_FLOOR2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'COUNT_COILS_FLOOR2'.
        /// </value>
        public int CountCoilsFloor2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COUNT_LOCATIONS_FLOOR2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'COUNT_LOCATIONS_FLOOR2'.
        /// </value>
        public int CountLocationsFloor2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RATE_FLOOR1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'RATE_FLOOR1'.
        /// </value>
        public decimal RateFloor1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RATE_FLOOR2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'RATE_FLOOR2'.
        /// </value>
        public decimal RateFloor2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RATE_ALL'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'RATE_ALL'.
        /// </value>
        public decimal? RateAll { get; set; }

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
