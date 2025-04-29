using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TPlBackReturnCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '库区CODE'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Mode'.
        /// '转库方式，1：实退，2：虚退'.
        /// </summary>
        /// <value>
        /// The property value for 'Mode'.
        /// </value>
        public int Mode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Reason'.
        /// '转库原因  长度200'.
        /// </summary>
        /// <value>
        /// The property value for 'Reason'.
        /// </value>
        public int? Reason { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RetReason'.
        /// '转库原因  长度200'.
        /// </summary>
        /// <value>
        /// The property value for 'RetReason'.
        /// </value>
        public string RetReason { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VehicleType'.
        /// '转库过程，A：P4(虚拟退)，B：过跨车/电平车'.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleType'.
        /// </value>
        public int? VehicleType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RetType'.
        /// '转库过程，A：P4(虚拟退)，B：过跨车/电平车'.
        /// </summary>
        /// <value>
        /// The property value for 'RetType'.
        /// </value>
        public string RetType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RequestSource'.
        /// '数据字典  转库说明 W01：母卷   W02：Y8-提出退库  W03：计划 W04：LB-提出退库   Z16：T21-提出退库 Z17：C3提出退库  Z18：T29-提出退库'.
        /// </summary>
        /// <value>
        /// The property value for 'RequestSource'.
        /// </value>
        public int? RequestSource { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RetSource'.
        /// '数据字典  转库说明 W01：母卷   W02：Y8-提出退库  W03：计划 W04：LB-提出退库   Z16：T21-提出退库 Z17：C3提出退库  Z18：T29-提出退库'.
        /// </summary>
        /// <value>
        /// The property value for 'RetSource'.
        /// </value>
        public string RetSource { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsRequestCofirm'.
        /// '退回包装库的请求确认，由REQUEST_SOURCE的另一方确认，0：未确认，1：Y8已确认 2:C3已确认'.
        /// </summary>
        /// <value>
        /// The property value for 'IsRequestCofirm'.
        /// </value>
        public int? IsRequestCofirm { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RetLocation'.
        /// '退回到包装课所选择的库位'.
        /// </summary>
        /// <value>
        /// The property value for 'RetLocation'.
        /// </value>
        public string RetLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackLocation'.
        /// '重新入成品库所选择的库位'.
        /// </summary>
        /// <value>
        /// The property value for 'BackLocation'.
        /// </value>
        public string BackLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanState'.
        /// '0:未处理 1：已排库位   2：预排任务  3：已生成任务'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanState'.
        /// </value>
        public int? PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ExecState'.
        /// '执行状态 0：未执行 1：正在执行 2：已完成'.
        /// </summary>
        /// <value>
        /// The property value for 'ExecState'.
        /// </value>
        public int? ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ResolveState'.
        /// '分解状态，0：未分解 1：已分解'.
        /// </summary>
        /// <value>
        /// The property value for 'ResolveState'.
        /// </value>
        public int? ResolveState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PriorityOperator'.
        /// '用户优先级'.
        /// </summary>
        /// <value>
        /// The property value for 'PriorityOperator'.
        /// </value>
        public int? PriorityOperator { get; set; }

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
