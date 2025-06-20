using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_train'.
    /// </summary>
    public partial class TTrTrain
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTrain"/> class.
        /// 火车信息跟踪表
        /// </summary>
        public TTrTrain()
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
        /// Gets or sets the property value representing column 'TRAIN_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRAIN_ID'.
        /// </value>
        public string TrainId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOUSE_ID'.
        /// 'ESP成品库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOUSE_ID'.
        /// </value>
        public string HouseId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPATCH_STATE'.
        /// '0：初始状态，1：（ESP成品库）已分配目标库，2：（ESP成品库）进库后车头分离，3：（ESP成品库）入库钢卷核对中，4：（ESP成品库）入库钢卷核对完成，5：（ESP成品库）火车挑库待确认，6：（ESP成品库）火车挑库确认完毕，7：（ESP成品库）火车任务创建完成，8：（ESP成品库）火车任务执行中，9：（ESP成品库）火车任务即将完成，10：（ESP成品库）火车任务已完成，11：（ESP成品库）出库前车头挂接完成，12：（冷轧原料库）火车到达，13：（冷轧原料库）火车分段待确认，14：（冷轧原料库）火车分段完成，15：（冷轧原料库）火车入库钢卷核对中，16：（冷轧原料库）火车入库钢卷核对完成，17：（冷轧原料库）火车入库任务创建完成，18：（冷轧原料库）火车入库即将完成，19：（冷轧原料库）火车入库完成，20：（冷轧原料库）火车离开确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPATCH_STATE'.
        /// </value>
        public int? DispatchState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POSITION_ID'.
        /// '数据字典中的火车位置节点'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POSITION_ID'.
        /// </value>
        public string PositionId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DIRECTION'.
        /// '1：ESP到冷轧原料 2：冷轧原料到ESP'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DIRECTION'.
        /// </value>
        public int? Direction { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_HOUSE'.
        /// '目标库房'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_HOUSE'.
        /// </value>
        public string DestHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_TYPE'.
        /// '1：空车无退卷， 2：空车退卷， 3：重车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_TYPE'.
        /// </value>
        public int? LoadType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SOURCE_HOUSE'.
        /// '装载库房'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SOURCE_HOUSE'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRAIN_HEAD_STATE'.
        /// '火车头状态，0：无，1：车头已分离，2：车头挂接完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRAIN_HEAD_STATE'.
        /// </value>
        public int? TrainHeadState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'INBOUND_CHECK_STATE'.
        /// '入库检查状态，0：无，1：正在检查，2：检查完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'INBOUND_CHECK_STATE'.
        /// </value>
        public int? InboundCheckState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_PICKED_COIL_CONFIRMED'.
        /// '挑库钢卷确认状态，0：未确认，1：已确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_PICKED_COIL_CONFIRMED'.
        /// </value>
        public int? IsPickedCoilConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_LOAD_PLANS_CONFIRMED'.
        /// '装车计划确认状态，0：未确认，1：已确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_LOAD_PLANS_CONFIRMED'.
        /// </value>
        public int? IsLoadPlansConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_FAULT'.
        /// '0：无，1：错误'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_FAULT'.
        /// </value>
        public int? IsFault { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRAIN_NO'.
        /// '车号，按时间序列生成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRAIN_NO'.
        /// </value>
        public string TrainNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CURRENT_TEAM_CONFIRMED'.
        /// '超期当前班确认状态  0：未确认，1：已确认   '.
        /// </summary>
        /// <value>
        /// The property value representing column 'CURRENT_TEAM_CONFIRMED'.
        /// </value>
        public int? CurrentTeamConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRAIN_INDEX'.
        /// '火车在库内的排列序号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRAIN_INDEX'.
        /// </value>
        public int? TrainIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BEFORE_TRAIN_ID'.
        /// '前面一组的火车ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BEFORE_TRAIN_ID'.
        /// </value>
        public string BeforeTrainId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LASER_DISTANCE'.
        /// '车头分离时的激光读数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LASER_DISTANCE'.
        /// </value>
        public int? LaserDistance { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PICK_COILS_MODE'.
        /// '挑卷模式，1：平整优先，2：酸洗优先'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PICK_COILS_MODE'.
        /// </value>
        public int? PickCoilsMode { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="TWhBay" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhBay" />.
        /// </value>
        /// <seealso cref="HouseId" />
        public virtual TWhBay HouseTWhBay { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TScDictionary" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TScDictionary" />.
        /// </value>
        /// <seealso cref="PositionId" />
        public virtual TScDictionary PositionTScDictionary { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TEqTrain" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TEqTrain" />.
        /// </value>
        /// <seealso cref="TrainId" />
        public virtual TEqTrain TrainTEqTrain { get; set; }

        #endregion

    }
}
