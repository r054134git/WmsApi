using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 过跨车基础信息
    /// </summary>
    public partial class TEqCrossVehicleReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '车辆名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Type'.
        /// '过跨设备类型 0：无，1：汽车，2：过跨车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value for 'Type'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayDistanceConfig'.
        /// 'JSON格式字符串，库区id/name/STACKID/停车位 LASER配置 laserDistance'.
        /// </summary>
        /// <value>
        /// The property value for 'BayDistanceConfig'.
        /// </value>
        public string BayDistanceConfig { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FenceAreaId'.
        /// '围栏区域id'.
        /// </summary>
        /// <value>
        /// The property value for 'FenceAreaId'.
        /// </value>
        public string FenceAreaId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LocationCount'.
        /// '车辆的有效鞍座数量'.
        /// </summary>
        /// <value>
        /// The property value for 'LocationCount'.
        /// </value>
        public int LocationCount { get; set; }

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
