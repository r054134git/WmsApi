using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_train_node'.
    /// </summary>
    public partial class TRcTrainNode
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTrainNode"/> class.
        /// 火车节点记录表
        /// </summary>
        public TRcTrainNode()
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
        /// Gets or sets the property value representing column 'TRAIN_NAME'.
        /// '火车名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRAIN_NAME'.
        /// </value>
        public string TrainName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NODE_NAME'.
        /// '节点名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NODE_NAME'.
        /// </value>
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ARRIVE_TIME'.
        /// '到达时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ARRIVE_TIME'.
        /// </value>
        public DateTime? ArriveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LEAVE_TIME'.
        /// '离开时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LEAVE_TIME'.
        /// </value>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DIRECTION'.
        /// '1:E TO P 2:P TO E'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DIRECTION'.
        /// </value>
        public int? Direction { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
