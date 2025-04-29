using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_conveying_chain'.
    /// </summary>
    public partial class TTrConveyingChain
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrConveyingChain"/> class.
        /// 运输链跟踪表
        /// </summary>
        public TTrConveyingChain()
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
        /// Gets or sets the property value representing column 'MATERIAL_ID'.
        /// '物料ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_ID'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_ID'.
        /// '当前库位ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_ID'.
        /// </value>
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ONLINE_TIME'.
        /// '上线时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ONLINE_TIME'.
        /// </value>
        public DateTime? OnlineTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CONVEYOR_ID'.
        /// '运输工具ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CONVEYOR_ID'.
        /// </value>
        public string ConveyorId { get; set; }

        #endregion

        #region Generated Relationships
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="ConveyorId" />
        public virtual TWhStack ConveyorTWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhLocation" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhLocation" />.
        /// </value>
        /// <seealso cref="LocationId" />
        public virtual TWhLocation LocationTWhLocation { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TPlMaterial" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TPlMaterial" />.
        /// </value>
        /// <seealso cref="MaterialId" />
        public virtual TPlMaterial MaterialTPlMaterial { get; set; }

        #endregion

    }
}
