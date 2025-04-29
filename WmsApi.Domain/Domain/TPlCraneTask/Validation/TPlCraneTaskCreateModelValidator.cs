using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlCraneTaskCreateModel"/> .
    /// </summary>
    public partial class TPlCraneTaskCreateModelValidator
        : AbstractValidator<TPlCraneTaskCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlCraneTaskCreateModelValidator"/> class.
        /// </summary>
        public TPlCraneTaskCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TaskNo).MaximumLength(30);
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.BayName).MaximumLength(30);
            RuleFor(p => p.CraneId).MaximumLength(32);
            RuleFor(p => p.CraneName).MaximumLength(30);
            RuleFor(p => p.UserCraneId).MaximumLength(32);
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.LoadLocationId).MaximumLength(32);
            RuleFor(p => p.LoadLocationName).MaximumLength(30);
            RuleFor(p => p.UnloadLocationId).MaximumLength(32);
            RuleFor(p => p.UnloadLocationName).MaximumLength(30);
            RuleFor(p => p.PlanTypeId).MaximumLength(32);
            RuleFor(p => p.PlanTypeName).MaximumLength(30);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
