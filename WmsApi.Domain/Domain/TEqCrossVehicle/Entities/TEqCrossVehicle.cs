using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_eq_cross_vehicle'.
    /// </summary>
    public partial class TEqCrossVehicle
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCrossVehicle"/> class.
        /// 过跨车基础信息
        /// </summary>
        public TEqCrossVehicle()
        {
            #region Generated Constructor
            VehicleTypeTPlBayTransfers = new HashSet<TPlBayTransfer>();
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
        /// Gets or sets the property value representing column 'NAME'.
        /// '车辆名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TYPE'.
        /// '过跨设备类型 0：无，1：汽车，2：过跨车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TYPE'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_DISTANCE_CONFIG'.
        /// 'JSON格式字符串，库区id/name/STACKID/停车位 LASER配置 laserDistance'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_DISTANCE_CONFIG'.
        /// </value>
        public string BayDistanceConfig { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FENCE_AREA_ID'.
        /// '围栏区域id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FENCE_AREA_ID'.
        /// </value>
        public string FenceAreaId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_COUNT'.
        /// '车辆的有效鞍座数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_COUNT'.
        /// </value>
        public int LocationCount { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TEqFenceArea" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TEqFenceArea" />.
        /// </value>
        /// <seealso cref="FenceAreaId" />
        public virtual TEqFenceArea FenceAreaTEqFenceArea { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlBayTransfer" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlBayTransfer" />.
        /// </value>
        public virtual ICollection<TPlBayTransfer> VehicleTypeTPlBayTransfers { get; set; }

        #endregion

    }
}
