using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class VProductionMaterialUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'No'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value for 'No'.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductionNo'.
        /// '生产计划号'.
        /// </summary>
        /// <value>
        /// The property value for 'ProductionNo'.
        /// </value>
        public string ProductionNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialId'.
        /// '材料ID'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialId'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '材料号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductionCoilSeq'.
        /// '生产计划钢卷序号'.
        /// </summary>
        /// <value>
        /// The property value for 'ProductionCoilSeq'.
        /// </value>
        public int? ProductionCoilSeq { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Thick'.
        /// '材料厚度mm'.
        /// </summary>
        /// <value>
        /// The property value for 'Thick'.
        /// </value>
        public decimal Thick { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Width'.
        /// '材料宽度mm'.
        /// </summary>
        /// <value>
        /// The property value for 'Width'.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Weight'.
        /// '产品卷重kg'.
        /// </summary>
        /// <value>
        /// The property value for 'Weight'.
        /// </value>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Length'.
        /// '产品长度'.
        /// </summary>
        /// <value>
        /// The property value for 'Length'.
        /// </value>
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Diameter'.
        /// '钢卷直径(外径)mm'.
        /// </summary>
        /// <value>
        /// The property value for 'Diameter'.
        /// </value>
        public int? Diameter { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InnerDiameter'.
        /// '内径'.
        /// </summary>
        /// <value>
        /// The property value for 'InnerDiameter'.
        /// </value>
        public int? InnerDiameter { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PortLotNumber'.
        /// '港口批号（新）'.
        /// </summary>
        /// <value>
        /// The property value for 'PortLotNumber'.
        /// </value>
        public string PortLotNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatDirection'.
        /// '材料去向(BMWM01 流向 U127)'.
        /// </summary>
        /// <value>
        /// The property value for 'MatDirection'.
        /// </value>
        public string MatDirection { get; set; }

        #endregion

    }
}
