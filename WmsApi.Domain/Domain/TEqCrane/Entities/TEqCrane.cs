using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_eq_crane'.
    /// </summary>
    public partial class TEqCrane
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCrane"/> class.
        /// 行车基础信息
        /// </summary>
        public TEqCrane()
        {
            #region Generated Constructor
            CraneTEqCraneWeights = new HashSet<TEqCraneWeight>();
            CraneTPlCraneTasks = new HashSet<TPlCraneTask>();
            CraneTTrCranes = new HashSet<TTrCrane>();
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
        /// '行车名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NO'.
        /// '行车编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NO'.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_X'.
        /// 'X方向的顺序（沿着X增大的方向排序：1 2 3）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_X'.
        /// </value>
        public int OrderX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WIDTH'.
        /// '宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH'.
        /// </value>
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_X'.
        /// '活动范围的相对坐标X最小值(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_X'.
        /// </value>
        public decimal MinX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_X'.
        /// '活动范围的相对坐标X最大值(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_X'.
        /// </value>
        public decimal MaxX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_X_BOTH'.
        /// '双车自动时X最小值（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_X_BOTH'.
        /// </value>
        public decimal? MinXBoth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_X_BOTH'.
        /// '双车自动时X最大值（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_X_BOTH'.
        /// </value>
        public decimal? MaxXBoth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_X_TRIPLE'.
        /// '三车自动时X最小值（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_X_TRIPLE'.
        /// </value>
        public decimal? MinXTriple { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_X_TRIPLE'.
        /// '三车自动时X最大值（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_X_TRIPLE'.
        /// </value>
        public decimal? MaxXTriple { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_Y'.
        /// '活动范围的相对坐标Y最小值(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_Y'.
        /// </value>
        public decimal MinY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_Y'.
        /// '活动范围的相对坐标Y最大值(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_Y'.
        /// </value>
        public decimal MaxY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_Z'.
        /// '吊具的最小Z值，单位（米）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_Z'.
        /// </value>
        public decimal MinZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_Z'.
        /// '吊具的最大Z值，单位（米）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_Z'.
        /// </value>
        public decimal MaxZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_ANGLE'.
        /// '夹钳最小角度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_ANGLE'.
        /// </value>
        public decimal? MinAngle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_ANGLE'.
        /// '夹钳最大角度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_ANGLE'.
        /// </value>
        public decimal? MaxAngle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MIN_WEIGHT'.
        /// '能吊的最小重量，Kg'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MIN_WEIGHT'.
        /// </value>
        public int? MinWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_WEIGHT'.
        /// '能吊的最大重量，Kg'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_WEIGHT'.
        /// </value>
        public int? MaxWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ACC_SPEED'.
        /// '加速度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ACC_SPEED'.
        /// </value>
        public decimal AccSpeed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPEED'.
        /// '速度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPEED'.
        /// </value>
        public decimal Speed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STANDBY_X'.
        /// '待机坐标X(m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STANDBY_X'.
        /// </value>
        public decimal StandbyX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STANDBY_Y'.
        /// '待机坐标Y(m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STANDBY_Y'.
        /// </value>
        public decimal StandbyY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STANDBY_ANGLE'.
        /// '待机角度(°)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STANDBY_ANGLE'.
        /// </value>
        public decimal StandbyAngle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAINTAINCE_X'.
        /// '检修坐标X(m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAINTAINCE_X'.
        /// </value>
        public decimal MaintainceX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAINTAINCE_Y'.
        /// '检修坐标Y(m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAINTAINCE_Y'.
        /// </value>
        public decimal MaintainceY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_AVOID_CAB'.
        /// '是否避让驾驶室'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_AVOID_CAB'.
        /// </value>
        public int? IsAvoidCab { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAB_MIN_Y'.
        /// '驾驶室最小Y数值'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAB_MIN_Y'.
        /// </value>
        public decimal? CabMinY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAB_MAX_Y'.
        /// '驾驶室最大Y数值'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAB_MAX_Y'.
        /// </value>
        public decimal? CabMaxY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAB_SAFE_Z'.
        /// '主钩安全旋转高度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAB_SAFE_Z'.
        /// </value>
        public decimal? CabSafeZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_AUTO_STANDBY_ENABLE'.
        /// '自动待机模式'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_AUTO_STANDBY_ENABLE'.
        /// </value>
        public int IsAutoStandbyEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_MIX_MODE_AVOID_ENABLE'.
        /// '混合避让模式'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_MIX_MODE_AVOID_ENABLE'.
        /// </value>
        public int IsMixModeAvoidEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_ID'.
        /// 'bayid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_ID'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STANDBY_X_DRIVER'.
        /// '请求上下车X坐标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STANDBY_X_DRIVER'.
        /// </value>
        public int? StandbyXDriver { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STANDBY_Y_DRIVER'.
        /// '请求上下车Y坐标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STANDBY_Y_DRIVER'.
        /// </value>
        public int? StandbyYDriver { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_DRIVER_STANDBY'.
        /// '1=请求成功，司机上车  0=取消请求 上车完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_DRIVER_STANDBY'.
        /// </value>
        public int? IsDriverStandby { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="TEqCraneWeight" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TEqCraneWeight" />.
        /// </value>
        public virtual ICollection<TEqCraneWeight> CraneTEqCraneWeights { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlCraneTask" />.
        /// </value>
        public virtual ICollection<TPlCraneTask> CraneTPlCraneTasks { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TTrCrane" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TTrCrane" />.
        /// </value>
        public virtual ICollection<TTrCrane> CraneTTrCranes { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhBay" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhBay" />.
        /// </value>
        /// <seealso cref="OwnerId" />
        public virtual TWhBay OwnerTWhBay { get; set; }

        #endregion

    }
}
