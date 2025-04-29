using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_wh_train_location'.
    /// </summary>
    public partial class TWhTrainLocation
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTrainLocation"/> class.
        /// 
        /// </summary>
        public TWhTrainLocation()
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
        /// Gets or sets the property value representing column 'LOCATION_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_ID'.
        /// </value>
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'X_IN_CAR'.
        /// '车厢相对X坐标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'X_IN_CAR'.
        /// </value>
        public decimal? XInCar { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Y_IN_CAR'.
        /// '车厢相对Y坐标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Y_IN_CAR'.
        /// </value>
        public decimal? YInCar { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ENABLE'.
        /// '是否可用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ENABLE'.
        /// </value>
        public int? IsEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// '创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime? CreateTime { get; set; }

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
        public DateTime? UpdateTime { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TWhLocation" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhLocation" />.
        /// </value>
        /// <seealso cref="LocationId" />
        public virtual TWhLocation LocationTWhLocation { get; set; }

        #endregion

    }
}
