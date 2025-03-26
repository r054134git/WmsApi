using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 火车节点记录表
    /// </summary>
    public partial class TRcTrainNodeCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TrainName'.
        /// '火车名称'.
        /// </summary>
        /// <value>
        /// The property value for 'TrainName'.
        /// </value>
        public string TrainName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NodeName'.
        /// '节点名称'.
        /// </summary>
        /// <value>
        /// The property value for 'NodeName'.
        /// </value>
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ArriveTime'.
        /// '到达时间'.
        /// </summary>
        /// <value>
        /// The property value for 'ArriveTime'.
        /// </value>
        public DateTime? ArriveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LeaveTime'.
        /// '离开时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LeaveTime'.
        /// </value>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Direction'.
        /// '1:E TO P 2:P TO E'.
        /// </summary>
        /// <value>
        /// The property value for 'Direction'.
        /// </value>
        public int? Direction { get; set; }

        #endregion

    }
}
