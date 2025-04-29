using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlFinishLineCreateModel"/> .
    /// </summary>
    public partial class TPlFinishLineCreateModelValidator
        : AbstractValidator<TPlFinishLineCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlFinishLineCreateModelValidator"/> class.
        /// </summary>
        public TPlFinishLineCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LineNo).MaximumLength(30);
            RuleFor(p => p.PlanNo).MaximumLength(30);
            RuleFor(p => p.PlanState).MaximumLength(1);
            RuleFor(p => p.PlanType).MaximumLength(3);
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
