using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcBayCreateModel"/> .
    /// </summary>
    public partial class TRcBayCreateModelValidator
        : AbstractValidator<TRcBayCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcBayCreateModelValidator"/> class.
        /// </summary>
        public TRcBayCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.PlanNo).NotEmpty();
            RuleFor(p => p.PlanNo).MaximumLength(30);
            RuleFor(p => p.MaterialId).NotEmpty();
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.MaterialNo).NotEmpty();
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.PlanTypeId).NotEmpty();
            RuleFor(p => p.PlanTypeId).MaximumLength(32);
            RuleFor(p => p.PlanTypeName).NotEmpty();
            RuleFor(p => p.PlanTypeName).MaximumLength(30);
            RuleFor(p => p.BayId).NotEmpty();
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.BayName).MaximumLength(255);
            RuleFor(p => p.BayTransferPlanId).MaximumLength(32);
            RuleFor(p => p.LoadLocationId).MaximumLength(32);
            RuleFor(p => p.LoadLocationName).MaximumLength(255);
            RuleFor(p => p.UnloadLocationId).MaximumLength(32);
            RuleFor(p => p.UnloadLocationName).MaximumLength(255);
            RuleFor(p => p.UserAccount).MaximumLength(30);
            RuleFor(p => p.Shift).MaximumLength(30);
            RuleFor(p => p.Team).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
