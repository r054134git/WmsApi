using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_eq_fence_area'.
    /// </summary>
    public partial class TEqFenceArea
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqFenceArea"/> class.
        /// 库区安全围栏区域
        /// </summary>
        public TEqFenceArea()
        {
            #region Generated Constructor
            FenceAreaTEqCrossVehicles = new HashSet<TEqCrossVehicle>();
            OwnerTEqFenceDoors = new HashSet<TEqFenceDoor>();
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
        /// '名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// 'BAYID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_X'.
        /// '最小坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_X'.
        /// </value>
        public decimal MinX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_X'.
        /// '最大坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_X'.
        /// </value>
        public decimal MaxX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_Y'.
        /// '最小坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_Y'.
        /// </value>
        public decimal MinY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_Y'.
        /// '最大坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_Y'.
        /// </value>
        public decimal MaxY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LINK_TARGET_TYPE'.
        /// '关联的目标设备类型，0：无，1：行车，2：过跨车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LINK_TARGET_TYPE'.
        /// </value>
        public int? LinkTargetType { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="TEqCrossVehicle" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqCrossVehicle" />.
        /// </value>
        public virtual ICollection<TEqCrossVehicle> FenceAreaTEqCrossVehicles { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqFenceDoor" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqFenceDoor" />.
        /// </value>
        public virtual ICollection<TEqFenceDoor> OwnerTEqFenceDoors { get; set; }

        #endregion

    }
}
