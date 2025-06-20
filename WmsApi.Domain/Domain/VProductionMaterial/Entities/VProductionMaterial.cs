using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 'v_production_material'.
    /// </summary>
    public partial class VProductionMaterial
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VProductionMaterial"/> class.
        /// 
        /// </summary>
        public VProductionMaterial()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'NO'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NO'.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRODUCTION_NO'.
        /// '生产计划号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCTION_NO'.
        /// </value>
        public string ProductionNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_ID'.
        /// '材料ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_ID'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// '材料号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRODUCTION_COIL_SEQ'.
        /// '生产计划钢卷序号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCTION_COIL_SEQ'.
        /// </value>
        public int? ProductionCoilSeq { get; set; }

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

        /// <summary>
        /// Gets or sets the property value representing column 'THICK'.
        /// '材料厚度mm'.
        /// </summary>
        /// <value>
        /// The property value representing column 'THICK'.
        /// </value>
        public decimal Thick { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WIDTH'.
        /// '材料宽度mm'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH'.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT'.
        /// '产品卷重kg'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT'.
        /// </value>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LENGTH'.
        /// '产品长度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LENGTH'.
        /// </value>
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DIAMETER'.
        /// '钢卷直径(外径)mm'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DIAMETER'.
        /// </value>
        public int? Diameter { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'INNER_DIAMETER'.
        /// '内径'.
        /// </summary>
        /// <value>
        /// The property value representing column 'INNER_DIAMETER'.
        /// </value>
        public int? InnerDiameter { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PORT_LOT_NUMBER'.
        /// '港口批号（新）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PORT_LOT_NUMBER'.
        /// </value>
        public string PortLotNumber { get; set; }

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
