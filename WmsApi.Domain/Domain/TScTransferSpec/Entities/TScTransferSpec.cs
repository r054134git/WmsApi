using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_sc_transfer_spec'.
    /// </summary>
    public partial class TScTransferSpec
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScTransferSpec"/> class.
        /// 数据字典表
        /// </summary>
        public TScTransferSpec()
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
        /// Gets or sets the property value representing column 'SPEC_WIDTH'.
        /// '宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPEC_WIDTH'.
        /// </value>
        public int? SpecWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BELONG_SPEC_WIDTH'.
        /// '归属宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BELONG_SPEC_WIDTH'.
        /// </value>
        public int? BelongSpecWidth { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
