using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="VCraneLocationCreateModel"/> .
    /// </summary>
    public partial class VCraneLocationCreateModelValidator
        : AbstractValidator<VCraneLocationCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCraneLocationCreateModelValidator"/> class.
        /// </summary>
        public VCraneLocationCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TaskNo).MaximumLength(30);
            RuleFor(p => p.CraneName).MaximumLength(30);
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.PlanTypeName).MaximumLength(30);
            RuleFor(p => p.LoadLocationName).MaximumLength(32);
            RuleFor(p => p.UnloadLocationName).MaximumLength(32);
            RuleFor(p => p.CreateTypeDesc).NotEmpty();
            RuleFor(p => p.CreateTypeDesc).MaximumLength(30);
            RuleFor(p => p.UpdateTypeDesc).MaximumLength(30);
            RuleFor(p => p.BayName).MaximumLength(30);
            RuleFor(p => p.TeamName).MaximumLength(30);
            RuleFor(p => p.ShiftName).MaximumLength(30);
            RuleFor(p => p.UserName).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
