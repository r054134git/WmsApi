using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库位基础信息
    /// </summary>
    public partial class TWhLocationUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '库位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '跨编码'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaCode'.
        /// '区编码'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaCode'.
        /// </value>
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RowNo'.
        /// '行号'.
        /// </summary>
        /// <value>
        /// The property value for 'RowNo'.
        /// </value>
        public int RowNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ColNo'.
        /// '列号'.
        /// </summary>
        /// <value>
        /// The property value for 'ColNo'.
        /// </value>
        public int ColNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FloorNo'.
        /// '层号'.
        /// </summary>
        /// <value>
        /// The property value for 'FloorNo'.
        /// </value>
        public int FloorNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PointX'.
        /// '与基准点的相对坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'PointX'.
        /// </value>
        public decimal PointX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PointY'.
        /// '与基准点的相对坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'PointY'.
        /// </value>
        public decimal PointY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PointZ'.
        /// '与基准点的相对坐标Z(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'PointZ'.
        /// </value>
        public decimal PointZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DevX'.
        /// '与基准点坐标X的偏差(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'DevX'.
        /// </value>
        public decimal? DevX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DevY'.
        /// '与基准点坐标Y的偏差(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'DevY'.
        /// </value>
        public decimal? DevY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Angle'.
        /// '鞍座的角度'.
        /// </summary>
        /// <value>
        /// The property value for 'Angle'.
        /// </value>
        public int Angle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Orientation'.
        /// '方向 1: 吊具角度与X轴平行  2：吊具角度与Y轴平行'.
        /// </summary>
        /// <value>
        /// The property value for 'Orientation'.
        /// </value>
        public int Orientation { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxZ'.
        /// '钢卷上沿的高度（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxZ'.
        /// </value>
        public decimal? MaxZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BaseWidth'.
        /// '基座宽度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'BaseWidth'.
        /// </value>
        public decimal BaseWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BaseLength'.
        /// '基座长度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'BaseLength'.
        /// </value>
        public decimal BaseLength { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BaseHeight'.
        /// '基座高度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'BaseHeight'.
        /// </value>
        public decimal BaseHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// '垛位ID'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaId'.
        /// '区域ID'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaId'.
        /// </value>
        public string AreaId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '单跨ID'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StorageType'.
        /// '库位类型，  0：无意义，  1：一般存储，  2：废卷存储，  3：倒垛临时存储，  4：汽车倒运备料，  5：运输工具备料，  6：任务接力，  7：安全保障预留，  8：其他用途预留，  9：运输工具鞍座，  10：钢卷修磨，  11：打包，  12：裸卷，  13：地面临时鞍座，  14：下线入库默认库位  101：汽车倒运，  102：火车倒运，  103：步进梁鞍座区，  104：电平车鞍座区，  105：过跨车鞍座区，  201：托卷小车出口鞍座区,   202：托卷小车入口鞍座区,   203：行车检修区域占用'.
        /// </summary>
        /// <value>
        /// The property value for 'StorageType'.
        /// </value>
        public int StorageType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadType'.
        /// '鞍座可吊取类型，  0：无意义，  1：起吊，  2：落吊，  3：起吊和落吊'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadType'.
        /// </value>
        public int LoadType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerBussinessName'.
        /// '业务区域名称(P4/P5/P6/P7/P8)'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerBussinessName'.
        /// </value>
        public string OwnerBussinessName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsVirtual'.
        /// '是否虚拟区'.
        /// </summary>
        /// <value>
        /// The property value for 'IsVirtual'.
        /// </value>
        public int IsVirtual { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsSharedToC3'.
        /// '是否共享给C3，0：不共享，1：共享'.
        /// </summary>
        /// <value>
        /// The property value for 'IsSharedToC3'.
        /// </value>
        public int IsSharedToC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaCodeC3'.
        /// 'C3存储区号'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaCodeC3'.
        /// </value>
        public string AreaCodeC3 { get; set; }

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
