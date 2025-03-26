using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_eq_train_car'.
    /// </summary>
    public partial class TEqTrainCar
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqTrainCar"/> class.
        /// 
        /// </summary>
        public TEqTrainCar()
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
        /// Gets or sets the property value representing column 'CAR_TYPE'.
        /// '车种，1：卷钢运输车，2：型钢运输车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR_TYPE'.
        /// </value>
        public int? CarType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STATE'.
        /// '状态，1：在线，2：故修'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STATE'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HEIGHT'.
        /// '高度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HEIGHT'.
        /// </value>
        public decimal? Height { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_LOAD'.
        /// '载重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_LOAD'.
        /// </value>
        public decimal? MaxLoad { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SADDLE_COUNT'.
        /// '鞍座数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SADDLE_COUNT'.
        /// </value>
        public int? SaddleCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// ''.
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
        /// <seealso cref="OwnerId" />
        public virtual TWhStack OwnerTWhStack { get; set; }

        #endregion

    }
}
