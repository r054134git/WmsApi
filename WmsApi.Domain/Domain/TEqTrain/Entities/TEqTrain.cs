using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_eq_train'.
    /// </summary>
    public partial class TEqTrain
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqTrain"/> class.
        /// 火车编组信息
        /// </summary>
        public TEqTrain()
        {
            #region Generated Constructor
            TrainTTrTrains = new HashSet<TTrTrain>();
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
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORT_INDEX'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT_INDEX'.
        /// </value>
        public int? SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR1_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR1_ID'.
        /// </value>
        public string Car1Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR2_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR2_ID'.
        /// </value>
        public string Car2Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR3_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR3_ID'.
        /// </value>
        public string Car3Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR4_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR4_ID'.
        /// </value>
        public string Car4Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR5_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR5_ID'.
        /// </value>
        public string Car5Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR6_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR6_ID'.
        /// </value>
        public string Car6Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR7_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR7_ID'.
        /// </value>
        public string Car7Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR8_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR8_ID'.
        /// </value>
        public string Car8Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR9_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR9_ID'.
        /// </value>
        public string Car9Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR10_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR10_ID'.
        /// </value>
        public string Car10Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR11_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR11_ID'.
        /// </value>
        public string Car11Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR12_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR12_ID'.
        /// </value>
        public string Car12Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR13_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR13_ID'.
        /// </value>
        public string Car13Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR14_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR14_ID'.
        /// </value>
        public string Car14Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR15_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR15_ID'.
        /// </value>
        public string Car15Id { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car10Id" />
        public virtual TWhStack Car10TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car11Id" />
        public virtual TWhStack Car11TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car12Id" />
        public virtual TWhStack Car12TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car13Id" />
        public virtual TWhStack Car13TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car14Id" />
        public virtual TWhStack Car14TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car15Id" />
        public virtual TWhStack Car15TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car1Id" />
        public virtual TWhStack Car1TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car2Id" />
        public virtual TWhStack Car2TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car3Id" />
        public virtual TWhStack Car3TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car4Id" />
        public virtual TWhStack Car4TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car5Id" />
        public virtual TWhStack Car5TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car6Id" />
        public virtual TWhStack Car6TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car7Id" />
        public virtual TWhStack Car7TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car8Id" />
        public virtual TWhStack Car8TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhStack" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhStack" />.
        /// </value>
        /// <seealso cref="Car9Id" />
        public virtual TWhStack Car9TWhStack { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TTrTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrTrain" />.
        /// </value>
        public virtual ICollection<TTrTrain> TrainTTrTrains { get; set; }

        #endregion

    }
}
