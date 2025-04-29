using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_wh_plan_type'.
    /// </summary>
    public partial class TWhPlanType
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhPlanType"/> class.
        /// 吊运计划任务类型
        /// </summary>
        public TWhPlanType()
        {
            #region Generated Constructor
            PlanTypeTPlBays = new HashSet<TPlBay>();
            PlanTypeTPlBayTransfers = new HashSet<TPlBayTransfer>();
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
        /// '吊运任务名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SIMPLE_NAME'.
        /// '简称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SIMPLE_NAME'.
        /// </value>
        public string SimpleName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CLASS_LABEL'.
        /// '分类标签'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CLASS_LABEL'.
        /// </value>
        public string ClassLabel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_LOCATION_TYPE'.
        /// '起点库位存储类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_LOCATION_TYPE'.
        /// </value>
        public int FromLocationType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_LOCATION_TYPE'.
        /// '目标库位存储类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_LOCATION_TYPE'.
        /// </value>
        public int DestLocationType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_BAY_ID'.
        /// '源跨区id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_BAY_ID'.
        /// </value>
        public string FromBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_BAY_ID'.
        /// '目的跨区id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_BAY_ID'.
        /// </value>
        public string DestBayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_OUT_TYPE'.
        /// '计划类型 1:入库，2:出库，3:倒垛, 4:退库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_OUT_TYPE'.
        /// </value>
        public int InOutType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_CROSS_BAY'.
        /// '0:不过跨 1：过跨'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_CROSS_BAY'.
        /// </value>
        public int IsCrossBay { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANS_TYPE'.
        /// '过跨设备类型 0：无，1：汽车，2：过跨车，3：电瓶车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANS_TYPE'.
        /// </value>
        public int TransType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_GROUND_COLOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_GROUND_COLOR'.
        /// </value>
        public string BackGroundColor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORT_SEQ'.
        /// '排序序号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT_SEQ'.
        /// </value>
        public int SortSeq { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEFAULT_PRIORITY'.
        /// '默认优先级'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEFAULT_PRIORITY'.
        /// </value>
        public int DefaultPriority { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TWhWarehouse" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhWarehouse" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TWhWarehouse OwnerTWhWarehouse { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlBay" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlBay" />.
        /// </value>
        public virtual ICollection<TPlBay> PlanTypeTPlBays { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlBayTransfer" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlBayTransfer" />.
        /// </value>
        public virtual ICollection<TPlBayTransfer> PlanTypeTPlBayTransfers { get; set; }

        #endregion

    }
}
