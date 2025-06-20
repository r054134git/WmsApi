using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 'v_material_event'.
    /// </summary>
    public partial class VMaterialEvent
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMaterialEvent"/> class.
        /// 
        /// </summary>
        public VMaterialEvent()
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
        /// '库区编码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_NAME'.
        /// '行车名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_NAME'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_ID'.
        /// '材料id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_ID'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DT'.
        /// '时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DT'.
        /// </value>
        public DateTime Dt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// '材料号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO_OLD'.
        /// '材料号变更前的钢卷号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO_OLD'.
        /// </value>
        public string MaterialNoOld { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OPERATION_TYPE'.
        /// '人工/自动'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OPERATION_TYPE'.
        /// </value>
        public string OperationType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CONTENT_TYPE'.
        /// '生产计划/入库计划/入库/倒库计划/倒库/出库计划/出库/退库计划/退库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CONTENT_TYPE'.
        /// </value>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_LOCATION_NAME'.
        /// '起点库位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_LOCATION_NAME'.
        /// </value>
        public string FromLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TO_LOCATION_NAME'.
        /// '终点库位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TO_LOCATION_NAME'.
        /// </value>
        public string ToLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DESCRIPTION'.
        /// '描述'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DESCRIPTION'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_POSITION'.
        /// '起点坐标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_POSITION'.
        /// </value>
        public string FromPosition { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TO_POSITION'.
        /// '终点坐标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TO_POSITION'.
        /// </value>
        public string ToPosition { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RESULT'.
        /// '成功/失败/撤销'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RESULT'.
        /// </value>
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMARK'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMARK'.
        /// </value>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT'.
        /// '产品卷重kg'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT'.
        /// </value>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_DIRECTION'.
        /// '材料去向(BMWM01 流向 U127)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_DIRECTION'.
        /// </value>
        public string MatDirection { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
