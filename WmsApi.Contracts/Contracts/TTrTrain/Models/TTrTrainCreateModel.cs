using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 火车信息跟踪表
    /// </summary>
    public partial class TTrTrainCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TrainId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TrainId'.
        /// </value>
        public string TrainId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HouseId'.
        /// 'ESP成品库'.
        /// </summary>
        /// <value>
        /// The property value for 'HouseId'.
        /// </value>
        public string HouseId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DispatchState'.
        /// '0：初始状态，1：（ESP成品库）已分配目标库，2：（ESP成品库）进库后车头分离，3：（ESP成品库）入库钢卷核对中，4：（ESP成品库）入库钢卷核对完成，5：（ESP成品库）火车挑库待确认，6：（ESP成品库）火车挑库确认完毕，7：（ESP成品库）火车任务创建完成，8：（ESP成品库）火车任务执行中，9：（ESP成品库）火车任务即将完成，10：（ESP成品库）火车任务已完成，11：（ESP成品库）出库前车头挂接完成，12：（冷轧原料库）火车到达，13：（冷轧原料库）火车分段待确认，14：（冷轧原料库）火车分段完成，15：（冷轧原料库）火车入库钢卷核对中，16：（冷轧原料库）火车入库钢卷核对完成，17：（冷轧原料库）火车入库任务创建完成，18：（冷轧原料库）火车入库即将完成，19：（冷轧原料库）火车入库完成，20：（冷轧原料库）火车离开确认'.
        /// </summary>
        /// <value>
        /// The property value for 'DispatchState'.
        /// </value>
        public int? DispatchState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PositionId'.
        /// '数据字典中的火车位置节点'.
        /// </summary>
        /// <value>
        /// The property value for 'PositionId'.
        /// </value>
        public string PositionId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Direction'.
        /// '1：ESP到冷轧原料 2：冷轧原料到ESP'.
        /// </summary>
        /// <value>
        /// The property value for 'Direction'.
        /// </value>
        public int? Direction { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestHouse'.
        /// '目标库房'.
        /// </summary>
        /// <value>
        /// The property value for 'DestHouse'.
        /// </value>
        public string DestHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadType'.
        /// '1：空车无退卷， 2：空车退卷， 3：重车'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadType'.
        /// </value>
        public int? LoadType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SourceHouse'.
        /// '装载库房'.
        /// </summary>
        /// <value>
        /// The property value for 'SourceHouse'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrainHeadState'.
        /// '火车头状态，0：无，1：车头已分离，2：车头挂接完成'.
        /// </summary>
        /// <value>
        /// The property value for 'TrainHeadState'.
        /// </value>
        public int? TrainHeadState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InboundCheckState'.
        /// '入库检查状态，0：无，1：正在检查，2：检查完成'.
        /// </summary>
        /// <value>
        /// The property value for 'InboundCheckState'.
        /// </value>
        public int? InboundCheckState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsPickedCoilConfirmed'.
        /// '挑库钢卷确认状态，0：未确认，1：已确认'.
        /// </summary>
        /// <value>
        /// The property value for 'IsPickedCoilConfirmed'.
        /// </value>
        public int? IsPickedCoilConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsLoadPlansConfirmed'.
        /// '装车计划确认状态，0：未确认，1：已确认'.
        /// </summary>
        /// <value>
        /// The property value for 'IsLoadPlansConfirmed'.
        /// </value>
        public int? IsLoadPlansConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsFault'.
        /// '0：无，1：错误'.
        /// </summary>
        /// <value>
        /// The property value for 'IsFault'.
        /// </value>
        public int? IsFault { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrainNo'.
        /// '车号，按时间序列生成'.
        /// </summary>
        /// <value>
        /// The property value for 'TrainNo'.
        /// </value>
        public string TrainNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CurrentTeamConfirmed'.
        /// '超期当前班确认状态  0：未确认，1：已确认   '.
        /// </summary>
        /// <value>
        /// The property value for 'CurrentTeamConfirmed'.
        /// </value>
        public int? CurrentTeamConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrainIndex'.
        /// '火车在库内的排列序号'.
        /// </summary>
        /// <value>
        /// The property value for 'TrainIndex'.
        /// </value>
        public int? TrainIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BeforeTrainId'.
        /// '前面一组的火车ID'.
        /// </summary>
        /// <value>
        /// The property value for 'BeforeTrainId'.
        /// </value>
        public string BeforeTrainId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LaserDistance'.
        /// '车头分离时的激光读数'.
        /// </summary>
        /// <value>
        /// The property value for 'LaserDistance'.
        /// </value>
        public int? LaserDistance { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PickCoilsMode'.
        /// '挑卷模式，1：平整优先，2：酸洗优先'.
        /// </summary>
        /// <value>
        /// The property value for 'PickCoilsMode'.
        /// </value>
        public int? PickCoilsMode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion

    }
}
