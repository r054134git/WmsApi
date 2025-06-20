using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhPlanTypeCreateModel"/> .
    /// </summary>
    public partial class TWhPlanTypeCreateModelValidator
        : AbstractValidator<TWhPlanTypeCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhPlanTypeCreateModelValidator"/> class.
        /// </summary>
        public TWhPlanTypeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.SimpleName).NotEmpty();
            RuleFor(p => p.SimpleName).MaximumLength(10);
            RuleFor(p => p.ClassLabel).NotEmpty();
            RuleFor(p => p.ClassLabel).MaximumLength(255);
            RuleFor(p => p.FromBayId).NotEmpty();
            RuleFor(p => p.FromBayId).MaximumLength(32);
            RuleFor(p => p.DestBayId).NotEmpty();
            RuleFor(p => p.DestBayId).MaximumLength(32);
            RuleFor(p => p.BackGroundColor).MaximumLength(255);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
