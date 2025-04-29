using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_wh_warehouse'.
    /// </summary>
    public partial class TWhWarehouse
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhWarehouse"/> class.
        /// 库区基础信息
        /// </summary>
        public TWhWarehouse()
        {
            #region Generated Constructor
            OwnerTWhBays = new HashSet<TWhBay>();
            OwnerTWhPlanTypes = new HashSet<TWhPlanType>();
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
        /// Gets or sets the property value representing column 'COMPANY'.
        /// '所属单位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COMPANY'.
        /// </value>
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WORKSHOP'.
        /// '所属车间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WORKSHOP'.
        /// </value>
        public string Workshop { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_PRIORITY'.
        /// '汽车发货的装车优先级。0：卷优先；1：板优先'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_PRIORITY'.
        /// </value>
        public int LoadPriority { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="TWhBay" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TWhBay" />.
        /// </value>
        public virtual ICollection<TWhBay> OwnerTWhBays { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TWhPlanType" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TWhPlanType" />.
        /// </value>
        public virtual ICollection<TWhPlanType> OwnerTWhPlanTypes { get; set; }

        #endregion

    }
}
