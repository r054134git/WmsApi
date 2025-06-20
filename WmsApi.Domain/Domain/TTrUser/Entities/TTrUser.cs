using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_user'.
    /// </summary>
    public partial class TTrUser
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrUser"/> class.
        /// 一般参数跟踪表
        /// </summary>
        public TTrUser()
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
        /// Gets or sets the property value representing column 'CLIENT_NAME'.
        /// '客户端名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CLIENT_NAME'.
        /// </value>
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOGIN_USER_ID'.
        /// '操作用户ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOGIN_USER_ID'.
        /// </value>
        public string LoginUserId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TEAM_ID'.
        /// '当前班组ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TEAM_ID'.
        /// </value>
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SHIFT_ID'.
        /// '班别Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SHIFT_ID'.
        /// </value>
        public string ShiftId { get; set; }

        #endregion

        #region Generated Relationships
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TUmShift" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TUmShift" />.
        /// </value>
        /// <seealso cref="ShiftId" />
        public virtual TUmShift ShiftTUmShift { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TScDictionary" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TScDictionary" />.
        /// </value>
        /// <seealso cref="TeamId" />
        public virtual TScDictionary TeamTScDictionary { get; set; }

        #endregion

    }
}
