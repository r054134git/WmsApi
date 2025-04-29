using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 运行区域信息
    /// </summary>
    public partial class TWhCraneTravelSpaceReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '区域名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Seq'.
        /// '区域编号'.
        /// </summary>
        /// <value>
        /// The property value for 'Seq'.
        /// </value>
        public int Seq { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OriginX'.
        /// '原点x'.
        /// </summary>
        /// <value>
        /// The property value for 'OriginX'.
        /// </value>
        public decimal OriginX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OriginY'.
        /// '原点y'.
        /// </summary>
        /// <value>
        /// The property value for 'OriginY'.
        /// </value>
        public decimal OriginY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LengthX'.
        /// 'X方向长度'.
        /// </summary>
        /// <value>
        /// The property value for 'LengthX'.
        /// </value>
        public decimal LengthX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LengthY'.
        /// 'Y方向长度'.
        /// </summary>
        /// <value>
        /// The property value for 'LengthY'.
        /// </value>
        public decimal LengthY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinZ'.
        /// 'Z方向最小高度'.
        /// </summary>
        /// <value>
        /// The property value for 'MinZ'.
        /// </value>
        public decimal MinZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Type'.
        /// '区域类型： 1：库区区域  2：限高区域   3：禁行区域  4：安全通道 5：安全联锁 6：非库区域'.
        /// </summary>
        /// <value>
        /// The property value for 'Type'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryType'.
        /// '进入方向：0：限制进出 1：X+侧 2：X-侧 4：Y+侧 8：Y-侧 3：X两侧 12：Y两侧'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryType'.
        /// </value>
        public int? EntryType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// 'bayid,库'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion
        public string Describe { get; set; }
        public string ButtonLeft { get; set; }
        public string ButtonRight { get; set; }
    }
}
