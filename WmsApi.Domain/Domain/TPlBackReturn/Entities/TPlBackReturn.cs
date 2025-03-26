using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_back_return'.
    /// </summary>
    public partial class TPlBackReturn
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBackReturn"/> class.
        /// 
        /// </summary>
        public TPlBackReturn()
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
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '库区CODE'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MODE'.
        /// '转库方式，1：实退，2：虚退'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MODE'.
        /// </value>
        public int Mode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REASON'.
        /// '转库原因  长度200'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REASON'.
        /// </value>
        public int? Reason { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RET_REASON'.
        /// '转库原因  长度200'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RET_REASON'.
        /// </value>
        public string RetReason { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VEHICLE_TYPE'.
        /// '转库过程，A：P4(虚拟退)，B：过跨车/电平车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VEHICLE_TYPE'.
        /// </value>
        public int? VehicleType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RET_TYPE'.
        /// '转库过程，A：P4(虚拟退)，B：过跨车/电平车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RET_TYPE'.
        /// </value>
        public string RetType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REQUEST_SOURCE'.
        /// '数据字典  转库说明 W01：母卷   W02：Y8-提出退库  W03：计划 W04：LB-提出退库   Z16：T21-提出退库 Z17：C3提出退库  Z18：T29-提出退库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REQUEST_SOURCE'.
        /// </value>
        public int? RequestSource { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RET_SOURCE'.
        /// '数据字典  转库说明 W01：母卷   W02：Y8-提出退库  W03：计划 W04：LB-提出退库   Z16：T21-提出退库 Z17：C3提出退库  Z18：T29-提出退库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RET_SOURCE'.
        /// </value>
        public string RetSource { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_REQUEST_COFIRM'.
        /// '退回包装库的请求确认，由REQUEST_SOURCE的另一方确认，0：未确认，1：Y8已确认 2:C3已确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_REQUEST_COFIRM'.
        /// </value>
        public int? IsRequestCofirm { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RET_LOCATION'.
        /// '退回到包装课所选择的库位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RET_LOCATION'.
        /// </value>
        public string RetLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_LOCATION'.
        /// '重新入成品库所选择的库位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_LOCATION'.
        /// </value>
        public string BackLocation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_STATE'.
        /// '0:未处理 1：已排库位   2：预排任务  3：已生成任务'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_STATE'.
        /// </value>
        public int? PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EXEC_STATE'.
        /// '执行状态 0：未执行 1：正在执行 2：已完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EXEC_STATE'.
        /// </value>
        public int? ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RESOLVE_STATE'.
        /// '分解状态，0：未分解 1：已分解'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RESOLVE_STATE'.
        /// </value>
        public int? ResolveState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRIORITY_OPERATOR'.
        /// '用户优先级'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRIORITY_OPERATOR'.
        /// </value>
        public int? PriorityOperator { get; set; }

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
        #endregion

    }
}
