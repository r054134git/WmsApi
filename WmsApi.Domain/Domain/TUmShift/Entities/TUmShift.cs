using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_um_shift'.
    /// </summary>
    public partial class TUmShift
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmShift"/> class.
        /// 班次信息
        /// </summary>
        public TUmShift()
        {
            #region Generated Constructor
            ShiftTTrUsers = new HashSet<TTrUser>();
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
        /// '班次名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'START_TIME'.
        /// '开始时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'START_TIME'.
        /// </value>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'END_TIME'.
        /// '结束时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'END_TIME'.
        /// </value>
        public DateTime EndTime { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="TTrUser" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrUser" />.
        /// </value>
        public virtual ICollection<TTrUser> ShiftTTrUsers { get; set; }

        #endregion

    }
}
