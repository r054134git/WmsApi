using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_traffic_light'.
    /// </summary>
    public partial class TTrTrafficLight
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTrafficLight"/> class.
        /// 吊车追踪
        /// </summary>
        public TTrTrafficLight()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// 'id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NAME'.
        /// '红绿灯名称（如：16库）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLC_NAME'.
        /// '红绿灯的PLC名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLC_NAME'.
        /// </value>
        public string PlcName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '库id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STATE'.
        /// '红绿灯状态（0：不亮；1：红灯亮；2绿灯亮； 3：全部亮；4：双灯闪烁）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STATE'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LAST_CMD'.
        /// '上次请求状态：0：不亮；1：红灯亮；2绿灯亮； 3：全部亮；4：双灯闪烁'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LAST_CMD'.
        /// </value>
        public int? LastCmd { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TWhBay" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhBay" />.
        /// </value>
        /// <seealso cref="BayId" />
        public virtual TWhBay BayTWhBay { get; set; }

        #endregion

    }
}
