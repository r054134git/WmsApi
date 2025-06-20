using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_wh_location'.
    /// </summary>
    public partial class TWhLocation
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhLocation"/> class.
        /// 库位基础信息
        /// </summary>
        public TWhLocation()
        {
            #region Generated Constructor
            LoadLocationTPlBays = new HashSet<TPlBay>();
            LoadLocationTPlCraneTasks = new HashSet<TPlCraneTask>();
            LocationTTrConveyingChains = new HashSet<TTrConveyingChain>();
            LocationTWhTrainLocations = new HashSet<TWhTrainLocation>();
            UnloadLocationTPlBays = new HashSet<TPlBay>();
            UnloadLocationTPlCraneTasks = new HashSet<TPlCraneTask>();
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
        /// '库位名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '跨编码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_CODE'.
        /// '区编码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_CODE'.
        /// </value>
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ROW_NO'.
        /// '行号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROW_NO'.
        /// </value>
        public int RowNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COL_NO'.
        /// '列号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COL_NO'.
        /// </value>
        public int ColNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FLOOR_NO'.
        /// '层号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FLOOR_NO'.
        /// </value>
        public int FloorNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_X'.
        /// '与基准点的相对坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_X'.
        /// </value>
        public decimal PointX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_Y'.
        /// '与基准点的相对坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_Y'.
        /// </value>
        public decimal PointY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_Z'.
        /// '与基准点的相对坐标Z(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_Z'.
        /// </value>
        public decimal PointZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEV_X'.
        /// '与基准点坐标X的偏差(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEV_X'.
        /// </value>
        public decimal? DevX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEV_Y'.
        /// '与基准点坐标Y的偏差(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEV_Y'.
        /// </value>
        public decimal? DevY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ANGLE'.
        /// '鞍座的角度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ANGLE'.
        /// </value>
        public int Angle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORIENTATION'.
        /// '方向 1: 吊具角度与X轴平行  2：吊具角度与Y轴平行'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORIENTATION'.
        /// </value>
        public int Orientation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_Z'.
        /// '钢卷上沿的高度（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_Z'.
        /// </value>
        public decimal? MaxZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BASE_WIDTH'.
        /// '基座宽度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BASE_WIDTH'.
        /// </value>
        public decimal BaseWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BASE_LENGTH'.
        /// '基座长度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BASE_LENGTH'.
        /// </value>
        public decimal BaseLength { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BASE_HEIGHT'.
        /// '基座高度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BASE_HEIGHT'.
        /// </value>
        public decimal BaseHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// '垛位ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_ID'.
        /// '区域ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_ID'.
        /// </value>
        public string AreaId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '单跨ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STORAGE_TYPE'.
        /// '库位类型，  0：无意义，  1：一般存储，  2：废卷存储，  3：倒垛临时存储，  4：汽车倒运备料，  5：运输工具备料，  6：任务接力，  7：安全保障预留，  8：其他用途预留，  9：运输工具鞍座，  10：钢卷修磨，  11：打包，  12：裸卷，  13：地面临时鞍座，  14：下线入库默认库位  101：汽车倒运，  102：火车倒运，  103：步进梁鞍座区，  104：电平车鞍座区，  105：过跨车鞍座区，  201：托卷小车出口鞍座区,   202：托卷小车入口鞍座区,   203：行车检修区域占用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STORAGE_TYPE'.
        /// </value>
        public int StorageType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_TYPE'.
        /// '鞍座可吊取类型，  0：无意义，  1：起吊，  2：落吊，  3：起吊和落吊'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_TYPE'.
        /// </value>
        public int LoadType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_BUSSINESS_NAME'.
        /// '业务区域名称(P4/P5/P6/P7/P8)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_BUSSINESS_NAME'.
        /// </value>
        public string OwnerBussinessName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_VIRTUAL'.
        /// '是否虚拟区'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_VIRTUAL'.
        /// </value>
        public int IsVirtual { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SHARED_TO_C3'.
        /// '是否共享给C3，0：不共享，1：共享'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SHARED_TO_C3'.
        /// </value>
        public int IsSharedToC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_CODE_C3'.
        /// 'C3存储区号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_CODE_C3'.
        /// </value>
        public string AreaCodeC3 { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="TPlBay" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlBay" />.
        /// </value>
        public virtual ICollection<TPlBay> LoadLocationTPlBays { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </value>
        public virtual ICollection<TPlCraneTask> LoadLocationTPlCraneTasks { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TTrConveyingChain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrConveyingChain" />.
        /// </value>
        public virtual ICollection<TTrConveyingChain> LocationTTrConveyingChains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TWhTrainLocation" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TWhTrainLocation" />.
        /// </value>
        public virtual ICollection<TWhTrainLocation> LocationTWhTrainLocations { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TWhStack OwnerTWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlBay" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlBay" />.
        /// </value>
        public virtual ICollection<TPlBay> UnloadLocationTPlBays { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </value>
        public virtual ICollection<TPlCraneTask> UnloadLocationTPlCraneTasks { get; set; }

        #endregion

    }
}
