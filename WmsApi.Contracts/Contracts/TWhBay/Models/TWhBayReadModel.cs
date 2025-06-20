using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 跨基础信息
    /// </summary>
    public partial class TWhBayReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '跨名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Code'.
        /// '跨代码'.
        /// </summary>
        /// <value>
        /// The property value for 'Code'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'No'.
        /// '跨编号'.
        /// </summary>
        /// <value>
        /// The property value for 'No'.
        /// </value>
        public int No { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// '库id'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PointX'.
        /// '基准点的相对坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'PointX'.
        /// </value>
        public decimal PointX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PointY'.
        /// '基准点的相对坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'PointY'.
        /// </value>
        public decimal PointY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Length'.
        /// '长度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'Length'.
        /// </value>
        public decimal Length { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Width'.
        /// '宽度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'Width'.
        /// </value>
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Height'.
        /// '高度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'Height'.
        /// </value>
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrainY'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TrainY'.
        /// </value>
        public decimal? TrainY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LocationCode'.
        /// '库位编码前缀'.
        /// </summary>
        /// <value>
        /// The property value for 'LocationCode'.
        /// </value>
        public string LocationCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LastUploadStockTime'.
        /// '上次上传库存到MES的时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LastUploadStockTime'.
        /// </value>
        public DateTime? LastUploadStockTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LastUploadDefectTime'.
        /// '上次上传缺陷到MES的时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LastUploadDefectTime'.
        /// </value>
        public DateTime? LastUploadDefectTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LastUploadWeightTime'.
        /// '上次上传重量到MES的时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LastUploadWeightTime'.
        /// </value>
        public DateTime? LastUploadWeightTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AutoPickCount'.
        /// '火运自动挑库数量'.
        /// </summary>
        /// <value>
        /// The property value for 'AutoPickCount'.
        /// </value>
        public int? AutoPickCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LocationNameFormat'.
        /// '库位编号格式'.
        /// </summary>
        /// <value>
        /// The property value for 'LocationNameFormat'.
        /// </value>
        public string LocationNameFormat { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsAxisLinkageEnabled'.
        /// '三轴联动启用'.
        /// </summary>
        /// <value>
        /// The property value for 'IsAxisLinkageEnabled'.
        /// </value>
        public int? IsAxisLinkageEnabled { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AxisLinkageRectX'.
        /// '三轴联动下降区域的X轴偏差'.
        /// </summary>
        /// <value>
        /// The property value for 'AxisLinkageRectX'.
        /// </value>
        public int? AxisLinkageRectX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AxisLinkageRectY'.
        /// '三轴联动下降区域的Y轴偏差'.
        /// </summary>
        /// <value>
        /// The property value for 'AxisLinkageRectY'.
        /// </value>
        public int? AxisLinkageRectY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AxisLinkageRectZ'.
        /// '三轴联动下降区域的z轴偏差'.
        /// </summary>
        /// <value>
        /// The property value for 'AxisLinkageRectZ'.
        /// </value>
        public int? AxisLinkageRectZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AvoidRectX'.
        /// '避让区的X轴允许的偏差'.
        /// </summary>
        /// <value>
        /// The property value for 'AvoidRectX'.
        /// </value>
        public int? AvoidRectX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AvoidRectY'.
        /// '避让区的Y轴允许的偏差'.
        /// </summary>
        /// <value>
        /// The property value for 'AvoidRectY'.
        /// </value>
        public int? AvoidRectY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AvoidRectZ'.
        /// '避让区的Z轴允许的偏差'.
        /// </summary>
        /// <value>
        /// The property value for 'AvoidRectZ'.
        /// </value>
        public int? AvoidRectZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadMovingZ'.
        /// '起吊行进标准高度'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadMovingZ'.
        /// </value>
        public int? LoadMovingZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadHoveringHeight'.
        /// '起吊悬停高度'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadHoveringHeight'.
        /// </value>
        public int? LoadHoveringHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadMovingZ'.
        /// '落吊行进标准高度'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadMovingZ'.
        /// </value>
        public int? UnloadMovingZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadHoveringHeight'.
        /// '落吊悬停高度'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadHoveringHeight'.
        /// </value>
        public int? UnloadHoveringHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PositioningLimitX'.
        /// '定位偏差上限X'.
        /// </summary>
        /// <value>
        /// The property value for 'PositioningLimitX'.
        /// </value>
        public int? PositioningLimitX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PositioningLimitY'.
        /// '定位偏差上限Y'.
        /// </summary>
        /// <value>
        /// The property value for 'PositioningLimitY'.
        /// </value>
        public int? PositioningLimitY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PositioningLimitZ'.
        /// '定位偏差上限Z'.
        /// </summary>
        /// <value>
        /// The property value for 'PositioningLimitZ'.
        /// </value>
        public int? PositioningLimitZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinDistanceBetweenCrane'.
        /// '行车之间的最小安全距离'.
        /// </summary>
        /// <value>
        /// The property value for 'MinDistanceBetweenCrane'.
        /// </value>
        public int? MinDistanceBetweenCrane { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CrossTrainPositionLimit'.
        /// '过跨车定位偏差上限'.
        /// </summary>
        /// <value>
        /// The property value for 'CrossTrainPositionLimit'.
        /// </value>
        public int? CrossTrainPositionLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ServerIp'.
        /// '服务器的IP地址'.
        /// </summary>
        /// <value>
        /// The property value for 'ServerIp'.
        /// </value>
        public string ServerIp { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsCalcDestLocation'.
        /// '是否自动计算目标步进梁的位置'.
        /// </summary>
        /// <value>
        /// The property value for 'IsCalcDestLocation'.
        /// </value>
        public int? IsCalcDestLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsScriptLocationAssign'.
        /// '是否启用脚本形式的库位分配'.
        /// </summary>
        /// <value>
        /// The property value for 'IsScriptLocationAssign'.
        /// </value>
        public int? IsScriptLocationAssign { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsScrapAssignLocation'.
        /// '是否为尾卷分配单独的库位'.
        /// </summary>
        /// <value>
        /// The property value for 'IsScrapAssignLocation'.
        /// </value>
        public int? IsScrapAssignLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsSafetyDoorEnabled'.
        /// '是否启用安全门的分区隔离'.
        /// </summary>
        /// <value>
        /// The property value for 'IsSafetyDoorEnabled'.
        /// </value>
        public int? IsSafetyDoorEnabled { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsAutoToC3'.
        /// '是否启用自动下线入库到C3的功能 0:不启用  1:启用'.
        /// </summary>
        /// <value>
        /// The property value for 'IsAutoToC3'.
        /// </value>
        public int IsAutoToC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsL2LocationTriangle'.
        /// '二层卷是否采用品字形摆放，即二层卷不相邻'.
        /// </summary>
        /// <value>
        /// The property value for 'IsL2LocationTriangle'.
        /// </value>
        public int? IsL2LocationTriangle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxCoilHeight'.
        /// '钢卷最高高度'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxCoilHeight'.
        /// </value>
        public decimal? MaxCoilHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrackingG3Index'.
        /// '三代行车追踪索引'.
        /// </summary>
        /// <value>
        /// The property value for 'TrackingG3Index'.
        /// </value>
        public int? TrackingG3Index { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrackingG2Index'.
        /// '二代行车追踪索引'.
        /// </summary>
        /// <value>
        /// The property value for 'TrackingG2Index'.
        /// </value>
        public int? TrackingG2Index { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckSafetyWidth'.
        /// '双排车的钢卷距离中心线的安全间隙（单侧）'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckSafetyWidth'.
        /// </value>
        public int? TruckSafetyWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckDevToEnd'.
        /// '双排车的钢卷到车尾的偏差'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckDevToEnd'.
        /// </value>
        public int? TruckDevToEnd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WarningLocsFloor1'.
        /// '一层警戒库存'.
        /// </summary>
        /// <value>
        /// The property value for 'WarningLocsFloor1'.
        /// </value>
        public decimal WarningLocsFloor1 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WarningLocsFloor2'.
        /// '二层警戒库存'.
        /// </summary>
        /// <value>
        /// The property value for 'WarningLocsFloor2'.
        /// </value>
        public decimal WarningLocsFloor2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WarningLocsAll'.
        /// '全库警戒库存'.
        /// </summary>
        /// <value>
        /// The property value for 'WarningLocsAll'.
        /// </value>
        public decimal WarningLocsAll { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AllowTruckloadingNum'.
        /// '允许最大装车数量'.
        /// </summary>
        /// <value>
        /// The property value for 'AllowTruckloadingNum'.
        /// </value>
        public int? AllowTruckloadingNum { get; set; }

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
