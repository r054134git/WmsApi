using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 垛位分区信息
    /// </summary>
    public partial class TWhAreaReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '存储区域名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Code'.
        /// '存储区域代码'.
        /// </summary>
        /// <value>
        /// The property value for 'Code'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerBussinessName'.
        /// '业务区域名称(P4/P5/P6/P7/P8)'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerBussinessName'.
        /// </value>
        public string OwnerBussinessName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// '跨信息ID'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsVirtual'.
        /// '是否虚拟区'.
        /// </summary>
        /// <value>
        /// The property value for 'IsVirtual'.
        /// </value>
        public int IsVirtual { get; set; }

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
