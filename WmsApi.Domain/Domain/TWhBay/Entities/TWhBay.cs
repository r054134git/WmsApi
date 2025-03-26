using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_wh_bay'.
    /// </summary>
    public partial class TWhBay
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhBay"/> class.
        /// 跨基础信息
        /// </summary>
        public TWhBay()
        {
            #region Generated Constructor
            BayTPlBays = new HashSet<TPlBay>();
            BayTPlCraneTasks = new HashSet<TPlCraneTask>();
            BayTTrCranes = new HashSet<TTrCrane>();
            BayTTrTrafficLights = new HashSet<TTrTrafficLight>();
            DestBayTPlBayTransfers = new HashSet<TPlBayTransfer>();
            DestBayTPlCrossBayTasks = new HashSet<TPlCrossBayTask>();
            FromBayTPlBayTransfers = new HashSet<TPlBayTransfer>();
            FromBayTPlCrossBayTasks = new HashSet<TPlCrossBayTask>();
            HouseTTrTrains = new HashSet<TTrTrain>();
            OwnerTEqCranes = new HashSet<TEqCrane>();
            OwnerTWhAreas = new HashSet<TWhArea>();
            OwnerTWhCraneTravelSpaces = new HashSet<TWhCraneTravelSpace>();
            OwnerTWhTruckPassages = new HashSet<TWhTruckPassage>();
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
        /// '跨名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CODE'.
        /// '跨代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CODE'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NO'.
        /// '跨编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NO'.
        /// </value>
        public int No { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// '库id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_X'.
        /// '基准点的相对坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_X'.
        /// </value>
        public decimal PointX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_Y'.
        /// '基准点的相对坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_Y'.
        /// </value>
        public decimal PointY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LENGTH'.
        /// '长度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LENGTH'.
        /// </value>
        public decimal Length { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WIDTH'.
        /// '宽度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH'.
        /// </value>
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HEIGHT'.
        /// '高度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HEIGHT'.
        /// </value>
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRAIN_Y'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRAIN_Y'.
        /// </value>
        public decimal? TrainY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_CODE'.
        /// '库位编码前缀'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_CODE'.
        /// </value>
        public string LocationCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LAST_UPLOAD_STOCK_TIME'.
        /// '上次上传库存到MES的时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LAST_UPLOAD_STOCK_TIME'.
        /// </value>
        public DateTime? LastUploadStockTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LAST_UPLOAD_DEFECT_TIME'.
        /// '上次上传缺陷到MES的时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LAST_UPLOAD_DEFECT_TIME'.
        /// </value>
        public DateTime? LastUploadDefectTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LAST_UPLOAD_WEIGHT_TIME'.
        /// '上次上传重量到MES的时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LAST_UPLOAD_WEIGHT_TIME'.
        /// </value>
        public DateTime? LastUploadWeightTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AUTO_PICK_COUNT'.
        /// '火运自动挑库数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AUTO_PICK_COUNT'.
        /// </value>
        public int? AutoPickCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_NAME_FORMAT'.
        /// '库位编号格式'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_NAME_FORMAT'.
        /// </value>
        public string LocationNameFormat { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_AXIS_LINKAGE_ENABLED'.
        /// '三轴联动启用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_AXIS_LINKAGE_ENABLED'.
        /// </value>
        public int? IsAxisLinkageEnabled { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AXIS_LINKAGE_RECT_X'.
        /// '三轴联动下降区域的X轴偏差'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AXIS_LINKAGE_RECT_X'.
        /// </value>
        public int? AxisLinkageRectX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AXIS_LINKAGE_RECT_Y'.
        /// '三轴联动下降区域的Y轴偏差'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AXIS_LINKAGE_RECT_Y'.
        /// </value>
        public int? AxisLinkageRectY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AXIS_LINKAGE_RECT_Z'.
        /// '三轴联动下降区域的z轴偏差'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AXIS_LINKAGE_RECT_Z'.
        /// </value>
        public int? AxisLinkageRectZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AVOID_RECT_X'.
        /// '避让区的X轴允许的偏差'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AVOID_RECT_X'.
        /// </value>
        public int? AvoidRectX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AVOID_RECT_Y'.
        /// '避让区的Y轴允许的偏差'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AVOID_RECT_Y'.
        /// </value>
        public int? AvoidRectY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AVOID_RECT_Z'.
        /// '避让区的Z轴允许的偏差'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AVOID_RECT_Z'.
        /// </value>
        public int? AvoidRectZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_MOVING_Z'.
        /// '起吊行进标准高度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_MOVING_Z'.
        /// </value>
        public int? LoadMovingZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_HOVERING_HEIGHT'.
        /// '起吊悬停高度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_HOVERING_HEIGHT'.
        /// </value>
        public int? LoadHoveringHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_MOVING_Z'.
        /// '落吊行进标准高度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_MOVING_Z'.
        /// </value>
        public int? UnloadMovingZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_HOVERING_HEIGHT'.
        /// '落吊悬停高度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_HOVERING_HEIGHT'.
        /// </value>
        public int? UnloadHoveringHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POSITIONING_LIMIT_X'.
        /// '定位偏差上限X'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POSITIONING_LIMIT_X'.
        /// </value>
        public int? PositioningLimitX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POSITIONING_LIMIT_Y'.
        /// '定位偏差上限Y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POSITIONING_LIMIT_Y'.
        /// </value>
        public int? PositioningLimitY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POSITIONING_LIMIT_Z'.
        /// '定位偏差上限Z'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POSITIONING_LIMIT_Z'.
        /// </value>
        public int? PositioningLimitZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_DISTANCE_BETWEEN_CRANE'.
        /// '行车之间的最小安全距离'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_DISTANCE_BETWEEN_CRANE'.
        /// </value>
        public int? MinDistanceBetweenCrane { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CROSS_TRAIN_POSITION_LIMIT'.
        /// '过跨车定位偏差上限'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CROSS_TRAIN_POSITION_LIMIT'.
        /// </value>
        public int? CrossTrainPositionLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SERVER_IP'.
        /// '服务器的IP地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SERVER_IP'.
        /// </value>
        public string ServerIp { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_CALC_DEST_LOCATION'.
        /// '是否自动计算目标步进梁的位置'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_CALC_DEST_LOCATION'.
        /// </value>
        public int? IsCalcDestLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SCRIPT_LOCATION_ASSIGN'.
        /// '是否启用脚本形式的库位分配'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SCRIPT_LOCATION_ASSIGN'.
        /// </value>
        public int? IsScriptLocationAssign { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SCRAP_ASSIGN_LOCATION'.
        /// '是否为尾卷分配单独的库位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SCRAP_ASSIGN_LOCATION'.
        /// </value>
        public int? IsScrapAssignLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SAFETY_DOOR_ENABLED'.
        /// '是否启用安全门的分区隔离'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SAFETY_DOOR_ENABLED'.
        /// </value>
        public int? IsSafetyDoorEnabled { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_AUTO_TO_C3'.
        /// '是否启用自动下线入库到C3的功能 0:不启用  1:启用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_AUTO_TO_C3'.
        /// </value>
        public int IsAutoToC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_L2_LOCATION_TRIANGLE'.
        /// '二层卷是否采用品字形摆放，即二层卷不相邻'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_L2_LOCATION_TRIANGLE'.
        /// </value>
        public int? IsL2LocationTriangle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_COIL_HEIGHT'.
        /// '钢卷最高高度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_COIL_HEIGHT'.
        /// </value>
        public decimal? MaxCoilHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRACKING_G3_INDEX'.
        /// '三代行车追踪索引'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRACKING_G3_INDEX'.
        /// </value>
        public int? TrackingG3Index { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRACKING_G2_INDEX'.
        /// '二代行车追踪索引'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRACKING_G2_INDEX'.
        /// </value>
        public int? TrackingG2Index { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_SAFETY_WIDTH'.
        /// '双排车的钢卷距离中心线的安全间隙（单侧）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_SAFETY_WIDTH'.
        /// </value>
        public int? TruckSafetyWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_DEV_TO_END'.
        /// '双排车的钢卷到车尾的偏差'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_DEV_TO_END'.
        /// </value>
        public int? TruckDevToEnd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WARNING_LOCS_FLOOR1'.
        /// '一层警戒库存'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WARNING_LOCS_FLOOR1'.
        /// </value>
        public decimal WarningLocsFloor1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WARNING_LOCS_FLOOR2'.
        /// '二层警戒库存'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WARNING_LOCS_FLOOR2'.
        /// </value>
        public decimal WarningLocsFloor2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WARNING_LOCS_ALL'.
        /// '全库警戒库存'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WARNING_LOCS_ALL'.
        /// </value>
        public decimal WarningLocsAll { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ALLOW_TRUCKLOADING_NUM'.
        /// '允许最大装车数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ALLOW_TRUCKLOADING_NUM'.
        /// </value>
        public int? AllowTruckloadingNum { get; set; }

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
        public virtual ICollection<TPlBay> BayTPlBays { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </value>
        public virtual ICollection<TPlCraneTask> BayTPlCraneTasks { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TTrCrane" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrCrane" />.
        /// </value>
        public virtual ICollection<TTrCrane> BayTTrCranes { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TTrTrafficLight" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrTrafficLight" />.
        /// </value>
        public virtual ICollection<TTrTrafficLight> BayTTrTrafficLights { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlBayTransfer" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlBayTransfer" />.
        /// </value>
        public virtual ICollection<TPlBayTransfer> DestBayTPlBayTransfers { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlCrossBayTask" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlCrossBayTask" />.
        /// </value>
        public virtual ICollection<TPlCrossBayTask> DestBayTPlCrossBayTasks { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlBayTransfer" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlBayTransfer" />.
        /// </value>
        public virtual ICollection<TPlBayTransfer> FromBayTPlBayTransfers { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlCrossBayTask" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlCrossBayTask" />.
        /// </value>
        public virtual ICollection<TPlCrossBayTask> FromBayTPlCrossBayTasks { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TTrTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrTrain" />.
        /// </value>
        public virtual ICollection<TTrTrain> HouseTTrTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TEqCrane" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqCrane" />.
        /// </value>
        public virtual ICollection<TEqCrane> OwnerTEqCranes { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TWhArea" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TWhArea" />.
        /// </value>
        public virtual ICollection<TWhArea> OwnerTWhAreas { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TWhCraneTravelSpace" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TWhCraneTravelSpace" />.
        /// </value>
        public virtual ICollection<TWhCraneTravelSpace> OwnerTWhCraneTravelSpaces { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TWhTruckPassage" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TWhTruckPassage" />.
        /// </value>
        public virtual ICollection<TWhTruckPassage> OwnerTWhTruckPassages { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhWarehouse" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhWarehouse" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TWhWarehouse OwnerTWhWarehouse { get; set; }

        #endregion

    }
}
