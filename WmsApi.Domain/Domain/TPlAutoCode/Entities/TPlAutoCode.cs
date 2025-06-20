using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_auto_code'.
    /// </summary>
    public partial class TPlAutoCode
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlAutoCode"/> class.
        /// 自动编码信息表
        /// </summary>
        public TPlAutoCode()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// '主键'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CODE_TYPE'.
        /// '序列号类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CODE_TYPE'.
        /// </value>
        public string CodeType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER'.
        /// '序列号所有者'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER'.
        /// </value>
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'INIT_NUM'.
        /// '序列号初值'.
        /// </summary>
        /// <value>
        /// The property value representing column 'INIT_NUM'.
        /// </value>
        public string InitNum { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'INIT_CYCLE'.
        /// '序列号递增'.
        /// </summary>
        /// <value>
        /// The property value representing column 'INIT_CYCLE'.
        /// </value>
        public string InitCycle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CUR_SERNUM'.
        /// '序列号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CUR_SERNUM'.
        /// </value>
        public string CurSernum { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ZERO_FLG'.
        /// '序列号长度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ZERO_FLG'.
        /// </value>
        public string ZeroFlg { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SEQUENCE_STYLE'.
        /// '序列号样式'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SEQUENCE_STYLE'.
        /// </value>
        public string SequenceStyle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MEMO'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MEMO'.
        /// </value>
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LAST_DATE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LAST_DATE'.
        /// </value>
        public DateTime? LastDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
