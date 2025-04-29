using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
	/// <summary>
	/// View Model class
	/// 垛位基础信息
	/// </summary>
	public partial class TWhStackReadModel
		: EntityReadModel
	{
		#region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Width'.
        /// '宽度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'Width'.
        /// </value>
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Length'.
        /// '长度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'Length'.
        /// </value>
        public decimal Length { get; set; }

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
        /// Gets or sets the property value for 'OwnerId'.
        /// '分区id'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxFloor'.
        /// '最高允许层数'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxFloor'.
        /// </value>
        public int MaxFloor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadMinWidth'.
        /// '转运设备专用的夹钳吊取及释放的宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadMinWidth'.
        /// </value>
        public decimal? UnloadMinWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StackNo'.
        /// '垛位号'.
        /// </summary>
        /// <value>
        /// The property value for 'StackNo'.
        /// </value>
        public int StackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Orientation'.
        /// '方向 1: 吊具角度与X轴平行  2：吊具角度与Y轴平行'.
        /// </summary>
        /// <value>
        /// The property value for 'Orientation'.
        /// </value>
        public int Orientation { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Type'.
        /// '1：库区，2：步进梁，3：运卷小车，4：过跨车，5：汽车，6：电瓶车，7：打包区，8：精整备料'.
        /// </summary>
        /// <value>
        /// The property value for 'Type'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsLockable'.
        /// '可锁定标识 0：不可锁定 1：可锁定'.
        /// </summary>
        /// <value>
        /// The property value for 'IsLockable'.
        /// </value>
        public int? IsLockable { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaNo'.
        /// '区域代码'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaNo'.
        /// </value>
        public string AreaNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadOrder'.
        /// '上下料顺序（不适用于库区）0：无意义  1：库位顺序号从小到大  2：库位顺序号从大到小'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadOrder'.
        /// </value>
        public int LoadOrder { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion
        /// <summary>
        /// 一层鞍座数量
        /// </summary>
        public int CoilPositionCount1 { get; set; }

        /// <summary>
        /// 一层钢卷数量
        /// </summary>
        public int CoilCount1 { get; set; }

        /// <summary>
        /// 二层鞍座数量
        /// </summary>
        public int CoilPositionCount2 { get; set; }

		public int LocationCount
		{
			get; set;
		}

        /// <summary>
        /// 二层钢卷数量
        /// </summary>
        public int CoilCount2 { get; set; }
        public int ColNo { get; set; }
        public List<TTrLocationMaterialReadModel> Items { get; set; } = new List<TTrLocationMaterialReadModel>();
    }
}
