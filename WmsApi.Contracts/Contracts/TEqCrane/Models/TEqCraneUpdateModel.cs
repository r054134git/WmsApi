using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 行车基础信息
    /// </summary>
    public partial class TEqCraneUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '行车名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'No'.
        /// '行车编号'.
        /// </summary>
        /// <value>
        /// The property value for 'No'.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderX'.
        /// 'X方向的顺序（沿着X增大的方向排序：1 2 3）'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderX'.
        /// </value>
        public int OrderX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Width'.
        /// '宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'Width'.
        /// </value>
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinX'.
        /// '活动范围的相对坐标X最小值(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MinX'.
        /// </value>
        public decimal MinX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxX'.
        /// '活动范围的相对坐标X最大值(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxX'.
        /// </value>
        public decimal MaxX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinXBoth'.
        /// '双车自动时X最小值（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value for 'MinXBoth'.
        /// </value>
        public decimal? MinXBoth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxXBoth'.
        /// '双车自动时X最大值（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxXBoth'.
        /// </value>
        public decimal? MaxXBoth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinXTriple'.
        /// '三车自动时X最小值（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value for 'MinXTriple'.
        /// </value>
        public decimal? MinXTriple { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxXTriple'.
        /// '三车自动时X最大值（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxXTriple'.
        /// </value>
        public decimal? MaxXTriple { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinY'.
        /// '活动范围的相对坐标Y最小值(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MinY'.
        /// </value>
        public decimal MinY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxY'.
        /// '活动范围的相对坐标Y最大值(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxY'.
        /// </value>
        public decimal MaxY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinZ'.
        /// '吊具的最小Z值，单位（米）'.
        /// </summary>
        /// <value>
        /// The property value for 'MinZ'.
        /// </value>
        public decimal MinZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxZ'.
        /// '吊具的最大Z值，单位（米）'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxZ'.
        /// </value>
        public decimal MaxZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinAngle'.
        /// '夹钳最小角度'.
        /// </summary>
        /// <value>
        /// The property value for 'MinAngle'.
        /// </value>
        public decimal? MinAngle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxAngle'.
        /// '夹钳最大角度'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxAngle'.
        /// </value>
        public decimal? MaxAngle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MinWeight'.
        /// '能吊的最小重量，Kg'.
        /// </summary>
        /// <value>
        /// The property value for 'MinWeight'.
        /// </value>
        public int? MinWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxWeight'.
        /// '能吊的最大重量，Kg'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxWeight'.
        /// </value>
        public int? MaxWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AccSpeed'.
        /// '加速度'.
        /// </summary>
        /// <value>
        /// The property value for 'AccSpeed'.
        /// </value>
        public decimal AccSpeed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Speed'.
        /// '速度'.
        /// </summary>
        /// <value>
        /// The property value for 'Speed'.
        /// </value>
        public decimal Speed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StandbyX'.
        /// '待机坐标X(m)'.
        /// </summary>
        /// <value>
        /// The property value for 'StandbyX'.
        /// </value>
        public decimal StandbyX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StandbyY'.
        /// '待机坐标Y(m)'.
        /// </summary>
        /// <value>
        /// The property value for 'StandbyY'.
        /// </value>
        public decimal StandbyY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StandbyAngle'.
        /// '待机角度(°)'.
        /// </summary>
        /// <value>
        /// The property value for 'StandbyAngle'.
        /// </value>
        public decimal StandbyAngle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaintainceX'.
        /// '检修坐标X(m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MaintainceX'.
        /// </value>
        public decimal MaintainceX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaintainceY'.
        /// '检修坐标Y(m)'.
        /// </summary>
        /// <value>
        /// The property value for 'MaintainceY'.
        /// </value>
        public decimal MaintainceY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsAvoidCab'.
        /// '是否避让驾驶室'.
        /// </summary>
        /// <value>
        /// The property value for 'IsAvoidCab'.
        /// </value>
        public int? IsAvoidCab { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CabMinY'.
        /// '驾驶室最小Y数值'.
        /// </summary>
        /// <value>
        /// The property value for 'CabMinY'.
        /// </value>
        public decimal? CabMinY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CabMaxY'.
        /// '驾驶室最大Y数值'.
        /// </summary>
        /// <value>
        /// The property value for 'CabMaxY'.
        /// </value>
        public decimal? CabMaxY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CabSafeZ'.
        /// '主钩安全旋转高度'.
        /// </summary>
        /// <value>
        /// The property value for 'CabSafeZ'.
        /// </value>
        public decimal? CabSafeZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsAutoStandbyEnable'.
        /// '自动待机模式'.
        /// </summary>
        /// <value>
        /// The property value for 'IsAutoStandbyEnable'.
        /// </value>
        public int IsAutoStandbyEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsMixModeAvoidEnable'.
        /// '混合避让模式'.
        /// </summary>
        /// <value>
        /// The property value for 'IsMixModeAvoidEnable'.
        /// </value>
        public int IsMixModeAvoidEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// 'bayid'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StandbyXDriver'.
        /// '请求上下车X坐标'.
        /// </summary>
        /// <value>
        /// The property value for 'StandbyXDriver'.
        /// </value>
        public int? StandbyXDriver { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StandbyYDriver'.
        /// '请求上下车Y坐标'.
        /// </summary>
        /// <value>
        /// The property value for 'StandbyYDriver'.
        /// </value>
        public int? StandbyYDriver { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsDriverStandby'.
        /// '1=请求成功，司机上车  0=取消请求 上车完成'.
        /// </summary>
        /// <value>
        /// The property value for 'IsDriverStandby'.
        /// </value>
        public int? IsDriverStandby { get; set; }

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
