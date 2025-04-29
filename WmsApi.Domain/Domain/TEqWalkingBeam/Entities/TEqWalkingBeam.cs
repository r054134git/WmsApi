using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_eq_walking_beam'.
    /// </summary>
    public partial class TEqWalkingBeam
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqWalkingBeam"/> class.
        /// 步进粱信息
        /// </summary>
        public TEqWalkingBeam()
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
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// 'BAYID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MOVE_FORWARD_ADDRESS'.
        /// '向前动作地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MOVE_FORWARD_ADDRESS'.
        /// </value>
        public string MoveForwardAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MOVE_BACKWARD_ADDRESS'.
        /// '向后动作地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MOVE_BACKWARD_ADDRESS'.
        /// </value>
        public string MoveBackwardAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GO_UP_ADDRESS'.
        /// '向上动作地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GO_UP_ADDRESS'.
        /// </value>
        public string GoUpAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GO_DOWN_ADDRESS'.
        /// '向下动作地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GO_DOWN_ADDRESS'.
        /// </value>
        public string GoDownAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCK_STATUS_ADDRESS'.
        /// '锁定状态地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCK_STATUS_ADDRESS'.
        /// </value>
        public string LockStatusAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCK_CMD_ADDRESS'.
        /// '锁定命令地址'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCK_CMD_ADDRESS'.
        /// </value>
        public string LockCmdAddress { get; set; }

        #endregion

        #region Generated Relationships
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TWhStack OwnerTWhStack { get; set; }

        #endregion

    }
}
