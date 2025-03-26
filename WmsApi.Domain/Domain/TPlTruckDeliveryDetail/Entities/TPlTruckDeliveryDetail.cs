using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_truck_delivery_detail'.
    /// </summary>
    public partial class TPlTruckDeliveryDetail
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckDeliveryDetail"/> class.
        /// 
        /// </summary>
        public TPlTruckDeliveryDetail()
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
        /// Gets or sets the property value representing column 'COIL_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'COIL_NO'.
        /// </value>
        public string CoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_PICKED'.
        /// '是否已挑库，0：未挑库，1：已挑库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_PICKED'.
        /// </value>
        public int? IsPicked { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PIKCED_TIME'.
        /// '挑库时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PIKCED_TIME'.
        /// </value>
        public DateTime? PikcedTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_LOADED'.
        /// '是否已装车，0：未装车，1：已装车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_LOADED'.
        /// </value>
        public int? IsLoaded { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOADED_TIME'.
        /// '装车时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOADED_TIME'.
        /// </value>
        public DateTime? LoadedTime { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TPlTruckDelivery" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TPlTruckDelivery" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TPlTruckDelivery OwnerTPlTruckDelivery { get; set; }

        #endregion

    }
}
