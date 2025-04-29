using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_wh_crane_travel_space'.
    /// </summary>
    public partial class TWhCraneTravelSpace
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhCraneTravelSpace"/> class.
        /// 运行区域信息
        /// </summary>
        public TWhCraneTravelSpace()
        {
            #region Generated Constructor
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
        /// '区域名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SEQ'.
        /// '区域编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SEQ'.
        /// </value>
        public int Seq { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORIGIN_X'.
        /// '原点x'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORIGIN_X'.
        /// </value>
        public decimal OriginX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORIGIN_Y'.
        /// '原点y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORIGIN_Y'.
        /// </value>
        public decimal OriginY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LENGTH_X'.
        /// 'X方向长度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LENGTH_X'.
        /// </value>
        public decimal LengthX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LENGTH_Y'.
        /// 'Y方向长度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LENGTH_Y'.
        /// </value>
        public decimal LengthY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_Z'.
        /// 'Z方向最小高度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_Z'.
        /// </value>
        public decimal MinZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TYPE'.
        /// '区域类型： 1：库区区域  2：限高区域   3：禁行区域  4：安全通道 5：安全联锁 6：非库区域'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TYPE'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ENTRY_TYPE'.
        /// '进入方向：0：限制进出 1：X+侧 2：X-侧 4：Y+侧 8：Y-侧 3：X两侧 12：Y两侧'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ENTRY_TYPE'.
        /// </value>
        public int? EntryType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// 'bayid,库'.
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
        /// Gets or sets the navigation property for entity <see cref="TWhBay" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhBay" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TWhBay OwnerTWhBay { get; set; }

        #endregion

    }
}
