using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlBayTransferCreateModel"/> .
    /// </summary>
    public partial class TPlBayTransferCreateModelValidator
        : AbstractValidator<TPlBayTransferCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBayTransferCreateModelValidator"/> class.
        /// </summary>
        public TPlBayTransferCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.No).MaximumLength(30);
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.MaterialNo).MaximumLength(300);
            RuleFor(p => p.PlanTypeId).NotEmpty();
            RuleFor(p => p.PlanTypeId).MaximumLength(32);
            RuleFor(p => p.PlanTypeName).MaximumLength(30);
            RuleFor(p => p.FromBayId).NotEmpty();
            RuleFor(p => p.FromBayId).MaximumLength(32);
            RuleFor(p => p.FromBayName).MaximumLength(30);
            RuleFor(p => p.DestBayId).NotEmpty();
            RuleFor(p => p.DestBayId).MaximumLength(32);
            RuleFor(p => p.DestBayName).MaximumLength(30);
            RuleFor(p => p.VehicleTypeId).MaximumLength(32);
            RuleFor(p => p.VehicleTypeName).MaximumLength(30);
            RuleFor(p => p.CrossBayTaskId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
