using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_wh_stack'.
    /// </summary>
    public partial class TWhStack
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhStack"/> class.
        /// 垛位基础信息
        /// </summary>
        public TWhStack()
        {
            #region Generated Constructor
            Car10TEqTrains = new HashSet<TEqTrain>();
            Car11TEqTrains = new HashSet<TEqTrain>();
            Car12TEqTrains = new HashSet<TEqTrain>();
            Car13TEqTrains = new HashSet<TEqTrain>();
            Car14TEqTrains = new HashSet<TEqTrain>();
            Car15TEqTrains = new HashSet<TEqTrain>();
            Car1TEqTrains = new HashSet<TEqTrain>();
            Car2TEqTrains = new HashSet<TEqTrain>();
            Car3TEqTrains = new HashSet<TEqTrain>();
            Car4TEqTrains = new HashSet<TEqTrain>();
            Car5TEqTrains = new HashSet<TEqTrain>();
            Car6TEqTrains = new HashSet<TEqTrain>();
            Car7TEqTrains = new HashSet<TEqTrain>();
            Car8TEqTrains = new HashSet<TEqTrain>();
            Car9TEqTrains = new HashSet<TEqTrain>();
            ConveyorTTrConveyingChains = new HashSet<TTrConveyingChain>();
            OwnerTEqCoilCars = new HashSet<TEqCoilCar>();
            OwnerTEqTrainCars = new HashSet<TEqTrainCar>();
            OwnerTEqWalkingBeams = new HashSet<TEqWalkingBeam>();
            OwnerTWhLocations = new HashSet<TWhLocation>();
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
        /// Gets or sets the property value representing column 'WIDTH'.
        /// '宽度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH'.
        /// </value>
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LENGTH'.
        /// '长度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LENGTH'.
        /// </value>
        public decimal Length { get; set; }

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
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// '分区id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_FLOOR'.
        /// '最高允许层数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_FLOOR'.
        /// </value>
        public int MaxFloor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_MIN_WIDTH'.
        /// '转运设备专用的夹钳吊取及释放的宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_MIN_WIDTH'.
        /// </value>
        public decimal? UnloadMinWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STACK_NO'.
        /// '垛位号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STACK_NO'.
        /// </value>
        public int StackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORIENTATION'.
        /// '方向 1: 吊具角度与X轴平行  2：吊具角度与Y轴平行'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORIENTATION'.
        /// </value>
        public int Orientation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TYPE'.
        /// '1：库区，2：步进梁，3：运卷小车，4：过跨车，5：汽车，6：电瓶车，7：打包区，8：精整备料'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TYPE'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_LOCKABLE'.
        /// '可锁定标识 0：不可锁定 1：可锁定'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_LOCKABLE'.
        /// </value>
        public int? IsLockable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_NO'.
        /// '区域代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_NO'.
        /// </value>
        public string AreaNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_ORDER'.
        /// '上下料顺序（不适用于库区）0：无意义  1：库位顺序号从小到大  2：库位顺序号从大到小'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_ORDER'.
        /// </value>
        public int LoadOrder { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car10TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car11TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car12TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car13TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car14TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car15TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car1TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car2TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car3TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car4TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car5TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car6TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car7TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car8TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrain" />.
        /// </value>
        public virtual ICollection<TEqTrain> Car9TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TTrConveyingChain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrConveyingChain" />.
        /// </value>
        public virtual ICollection<TTrConveyingChain> ConveyorTTrConveyingChains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqCoilCar" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqCoilCar" />.
        /// </value>
        public virtual ICollection<TEqCoilCar> OwnerTEqCoilCars { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqTrainCar" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqTrainCar" />.
        /// </value>
        public virtual ICollection<TEqTrainCar> OwnerTEqTrainCars { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqWalkingBeam" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqWalkingBeam" />.
        /// </value>
        public virtual ICollection<TEqWalkingBeam> OwnerTEqWalkingBeams { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhArea" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhArea" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TWhArea OwnerTWhArea { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TWhLocation" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TWhLocation" />.
        /// </value>
        public virtual ICollection<TWhLocation> OwnerTWhLocations { get; set; }

        #endregion

    }
}
