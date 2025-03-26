using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 步进粱信息
    /// </summary>
    public partial class TEqWalkingBeamUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// 'BAYID'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MoveForwardAddress'.
        /// '向前动作地址'.
        /// </summary>
        /// <value>
        /// The property value for 'MoveForwardAddress'.
        /// </value>
        public string MoveForwardAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MoveBackwardAddress'.
        /// '向后动作地址'.
        /// </summary>
        /// <value>
        /// The property value for 'MoveBackwardAddress'.
        /// </value>
        public string MoveBackwardAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GoUpAddress'.
        /// '向上动作地址'.
        /// </summary>
        /// <value>
        /// The property value for 'GoUpAddress'.
        /// </value>
        public string GoUpAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GoDownAddress'.
        /// '向下动作地址'.
        /// </summary>
        /// <value>
        /// The property value for 'GoDownAddress'.
        /// </value>
        public string GoDownAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LockStatusAddress'.
        /// '锁定状态地址'.
        /// </summary>
        /// <value>
        /// The property value for 'LockStatusAddress'.
        /// </value>
        public string LockStatusAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LockCmdAddress'.
        /// '锁定命令地址'.
        /// </summary>
        /// <value>
        /// The property value for 'LockCmdAddress'.
        /// </value>
        public string LockCmdAddress { get; set; }

        #endregion

    }
}
