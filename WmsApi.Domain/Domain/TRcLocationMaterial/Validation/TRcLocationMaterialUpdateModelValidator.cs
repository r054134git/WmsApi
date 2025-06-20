using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcLocationMaterialUpdateModel"/> .
    /// </summary>
    public partial class TRcLocationMaterialUpdateModelValidator
        : AbstractValidator<TRcLocationMaterialUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLocationMaterialUpdateModelValidator"/> class.
        /// </summary>
        public TRcLocationMaterialUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.WarehouseId).NotEmpty();
            RuleFor(p => p.WarehouseId).MaximumLength(32);
            RuleFor(p => p.BayId).NotEmpty();
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.AreaId).NotEmpty();
            RuleFor(p => p.AreaId).MaximumLength(32);
            RuleFor(p => p.StackId).NotEmpty();
            RuleFor(p => p.StackId).MaximumLength(32);
            RuleFor(p => p.LocationId).NotEmpty();
            RuleFor(p => p.LocationId).MaximumLength(32);
            RuleFor(p => p.LocationName).NotEmpty();
            RuleFor(p => p.LocationName).MaximumLength(255);
            RuleFor(p => p.BayCode).MaximumLength(30);
            RuleFor(p => p.AreaCode).NotEmpty();
            RuleFor(p => p.AreaCode).MaximumLength(30);
            RuleFor(p => p.OwnerBussinessName).NotEmpty();
            RuleFor(p => p.OwnerBussinessName).MaximumLength(32);
            RuleFor(p => p.AreaCodeC3).MaximumLength(255);
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.MaterialOwner).MaximumLength(32);
            RuleFor(p => p.ProcessCode).MaximumLength(30);
            RuleFor(p => p.NextProcessCode).MaximumLength(20);
            RuleFor(p => p.ProductPackFlag).MaximumLength(1);
            RuleFor(p => p.SteelGrade).MaximumLength(30);
            RuleFor(p => p.ProdTime).MaximumLength(14);
            RuleFor(p => p.SgSign).MaximumLength(50);
            RuleFor(p => p.SgStd).MaximumLength(100);
            RuleFor(p => p.OrderNo).MaximumLength(20);
            RuleFor(p => p.MatDirection).MaximumLength(5);
            RuleFor(p => p.MatStatus).MaximumLength(32);
            RuleFor(p => p.MatDisposeCode).MaximumLength(1);
            RuleFor(p => p.HoldFlag).MaximumLength(1);
            RuleFor(p => p.HoldCauseCode).MaximumLength(4);
            RuleFor(p => p.HoldRemark).MaximumLength(300);
            RuleFor(p => p.RelMaker).MaximumLength(24);
            RuleFor(p => p.RelRemark).MaximumLength(300);
            RuleFor(p => p.RelTime).MaximumLength(14);
            RuleFor(p => p.BillOfLadingNo).MaximumLength(13);
            RuleFor(p => p.ComplexDecideCode).MaximumLength(1);
            RuleFor(p => p.OrderName).MaximumLength(255);
            RuleFor(p => p.CustomerName).MaximumLength(100);
            RuleFor(p => p.CustomerCode).MaximumLength(10);
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.PrepickTransferNo).MaximumLength(20);
            RuleFor(p => p.TruckLoadListId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            RuleFor(p => p.ShiftDayNight).MaximumLength(5);
            RuleFor(p => p.ShiftName).MaximumLength(5);
            RuleFor(p => p.MaterialLockedFlag).NotEmpty();
            RuleFor(p => p.MaterialLockedFlag).MaximumLength(2);
            RuleFor(p => p.PlanCmdC3).MaximumLength(255);
            #endregion
        }

    }
}
