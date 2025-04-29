using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlCranePlanTypeCreateModel"/> .
    /// </summary>
    public partial class TRlCranePlanTypeCreateModelValidator
        : AbstractValidator<TRlCranePlanTypeCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlCranePlanTypeCreateModelValidator"/> class.
        /// </summary>
        public TRlCranePlanTypeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayCode).MaximumLength(32);
            RuleFor(p => p.CraneId).MaximumLength(32);
            RuleFor(p => p.CraneName).MaximumLength(32);
            RuleFor(p => p.PlanTypeName1).MaximumLength(255);
            RuleFor(p => p.PlanTypeName2).MaximumLength(255);
            RuleFor(p => p.PlanTypeName3).MaximumLength(255);
            RuleFor(p => p.PlanTypeName4).MaximumLength(255);
            RuleFor(p => p.PlanTypeName5).MaximumLength(255);
            RuleFor(p => p.PlanTypeName6).MaximumLength(255);
            RuleFor(p => p.PlanTypeName7).MaximumLength(255);
            RuleFor(p => p.PlanTypeName8).MaximumLength(255);
            RuleFor(p => p.PlanTypeName9).MaximumLength(255);
            RuleFor(p => p.PlanTypeName10).MaximumLength(255);
            RuleFor(p => p.PlanTypeName11).MaximumLength(255);
            RuleFor(p => p.PlanTypeName12).MaximumLength(255);
            RuleFor(p => p.AreaCode).MaximumLength(255);
            RuleFor(p => p.UnloadAreaCode).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
