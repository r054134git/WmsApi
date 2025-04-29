using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_sc_dictionary'.
    /// </summary>
    public partial class TScDictionary
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScDictionary"/> class.
        /// 数据字典表
        /// </summary>
        public TScDictionary()
        {
            #region Generated Constructor
            OwnerTScDictionaries = new HashSet<TScDictionary>();
            PositionTTrTrains = new HashSet<TTrTrain>();
            TeamTTrUsers = new HashSet<TTrUser>();
            TeamTUmUsers = new HashSet<TUmUser>();
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
        /// Gets or sets the property value representing column 'KEY'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'KEY'.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VALUE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'VALUE'.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SEQ'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SEQ'.
        /// </value>
        public int Seq { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER'.
        /// </value>
        public string Owner { get; set; }

        #endregion

        #region Generated Relationships
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TScDictionary" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TScDictionary" />.
        /// </value>
        public virtual ICollection<TScDictionary> OwnerTScDictionaries { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TScDictionary" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TScDictionary" />.
        /// </value>
        /// <seealso cref="Owner" />
        public virtual TScDictionary OwnerTScDictionary { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TTrTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrTrain" />.
        /// </value>
        public virtual ICollection<TTrTrain> PositionTTrTrains { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TTrUser" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrUser" />.
        /// </value>
        public virtual ICollection<TTrUser> TeamTTrUsers { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TUmUser" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TUmUser" />.
        /// </value>
        public virtual ICollection<TUmUser> TeamTUmUsers { get; set; }

        #endregion

    }
}
