using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_stack_tranfer'.
    /// </summary>
    public partial class TPlStackTranfer
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlStackTranfer"/> class.
        /// 
        /// </summary>
        public TPlStackTranfer()
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
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_ID'.
        /// '区id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_ID'.
        /// </value>
        public string AreaId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'START_STACK_ID'.
        /// '起点垛id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'START_STACK_ID'.
        /// </value>
        public string StartStackId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'END_STACK_ID'.
        /// '结束垛id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'END_STACK_ID'.
        /// </value>
        public string EndStackId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'START_COL_ID'.
        /// '起点列id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'START_COL_ID'.
        /// </value>
        public string StartColId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'END_COL_ID'.
        /// '终点列id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'END_COL_ID'.
        /// </value>
        public string EndColId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_POINT_X'.
        /// '起点X'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_POINT_X'.
        /// </value>
        public decimal? FromPointX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FROM_POINT_Y'.
        /// '起点Y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FROM_POINT_Y'.
        /// </value>
        public decimal? FromPointY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_POINT_X'.
        /// '终点X'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_POINT_X'.
        /// </value>
        public decimal? DestPointX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_POINT_Y'.
        /// '终点Y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_POINT_Y'.
        /// </value>
        public decimal? DestPointY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TYPE'.
        /// '计划类型，1：批量倒垛 2：配载备料 3：发货备料'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TYPE'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_COUNT'.
        /// '计划数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_COUNT'.
        /// </value>
        public int PlanCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TODO_COUNT'.
        /// '剩余计划数量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TODO_COUNT'.
        /// </value>
        public int TodoCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO_LIST'.
        /// 'JSON格式字符串，物料号/materialNo'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO_LIST'.
        /// </value>
        public string MaterialNoList { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO_LIST_ALL'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO_LIST_ALL'.
        /// </value>
        public string MaterialNoListAll { get; set; }

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
