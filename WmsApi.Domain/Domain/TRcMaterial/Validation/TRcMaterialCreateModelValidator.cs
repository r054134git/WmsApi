using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcMaterialCreateModel"/> .
    /// </summary>
    public partial class TRcMaterialCreateModelValidator
        : AbstractValidator<TRcMaterialCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcMaterialCreateModelValidator"/> class.
        /// </summary>
        public TRcMaterialCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.RecCreator).MaximumLength(24);
            RuleFor(p => p.RecCreateTime).MaximumLength(14);
            RuleFor(p => p.RecRevisor).MaximumLength(24);
            RuleFor(p => p.RecReviseTime).MaximumLength(14);
            RuleFor(p => p.No).NotEmpty();
            RuleFor(p => p.No).MaximumLength(30);
            RuleFor(p => p.MotherNo).MaximumLength(30);
            RuleFor(p => p.BundlePackageNo).MaximumLength(30);
            RuleFor(p => p.ProcessCode).MaximumLength(30);
            RuleFor(p => p.NextProcessCode).MaximumLength(20);
            RuleFor(p => p.MatShapeFlag).MaximumLength(1);
            RuleFor(p => p.MatStatus).MaximumLength(30);
            RuleFor(p => p.MeasureWtFlag).MaximumLength(1);
            RuleFor(p => p.ProductPackFlag).MaximumLength(1);
            RuleFor(p => p.Pono).MaximumLength(10);
            RuleFor(p => p.HeatNo).MaximumLength(12);
            RuleFor(p => p.SteelGrade).MaximumLength(30);
            RuleFor(p => p.ProdTime).MaximumLength(14);
            RuleFor(p => p.ProdShiftNo).MaximumLength(1);
            RuleFor(p => p.ProdShiftGroup).MaximumLength(1);
            RuleFor(p => p.SgSign).MaximumLength(50);
            RuleFor(p => p.SgStd).MaximumLength(100);
            RuleFor(p => p.OldSgSign).MaximumLength(50);
            RuleFor(p => p.OldSgStd).MaximumLength(100);
            RuleFor(p => p.OrderNo).MaximumLength(20);
            RuleFor(p => p.OldOrderNo).MaximumLength(20);
            RuleFor(p => p.MatDirection).MaximumLength(5);
            RuleFor(p => p.TrnpModeCode).MaximumLength(1);
            RuleFor(p => p.PackingTypeCode).MaximumLength(5);
            RuleFor(p => p.LabelDemand).MaximumLength(255);
            RuleFor(p => p.ReadyState).MaximumLength(1);
            RuleFor(p => p.ProdCode).MaximumLength(5);
            RuleFor(p => p.ProdCname).MaximumLength(255);
            RuleFor(p => p.ProdEname).MaximumLength(255);
            RuleFor(p => p.HoldFlag).MaximumLength(1);
            RuleFor(p => p.HoldCauseCode).MaximumLength(4);
            RuleFor(p => p.HoldTime).MaximumLength(14);
            RuleFor(p => p.HoldMaker).MaximumLength(24);
            RuleFor(p => p.ColorDemand).MaximumLength(255);
            RuleFor(p => p.HoldRemark).MaximumLength(300);
            RuleFor(p => p.RelMaker).MaximumLength(24);
            RuleFor(p => p.RelRemark).MaximumLength(300);
            RuleFor(p => p.RelTime).MaximumLength(14);
            RuleFor(p => p.RemainDecideCode).MaximumLength(4);
            RuleFor(p => p.RemainCauseCode).MaximumLength(4);
            RuleFor(p => p.RemainDecideTime).MaximumLength(14);
            RuleFor(p => p.RemainDecideMaker).MaximumLength(24);
            RuleFor(p => p.RemainRemark).MaximumLength(300);
            RuleFor(p => p.Msc).MaximumLength(20);
            RuleFor(p => p.OldMsc).MaximumLength(20);
            RuleFor(p => p.Psc).MaximumLength(25);
            RuleFor(p => p.OldPsc).MaximumLength(25);
            RuleFor(p => p.Apn).MaximumLength(4);
            RuleFor(p => p.OldApn).MaximumLength(4);
            RuleFor(p => p.BillOfLadingNo).MaximumLength(13);
            RuleFor(p => p.MatDisposeCode).MaximumLength(1);
            RuleFor(p => p.ComplexDecideCode).MaximumLength(1);
            RuleFor(p => p.OrderName).MaximumLength(255);
            RuleFor(p => p.CustomerName).MaximumLength(100);
            RuleFor(p => p.CustomerCode).MaximumLength(10);
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.DeliveryDate).MaximumLength(8);
            RuleFor(p => p.EndUserCode).MaximumLength(12);
            RuleFor(p => p.PrepickTransferNo).MaximumLength(20);
            RuleFor(p => p.TruckLoadListId).MaximumLength(32);
            RuleFor(p => p.DefectRecorder).MaximumLength(20);
            RuleFor(p => p.DefectDesc).MaximumLength(255);
            RuleFor(p => p.BayName).MaximumLength(50);
            RuleFor(p => p.MaterialOwner).NotEmpty();
            RuleFor(p => p.MaterialOwner).MaximumLength(2);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
