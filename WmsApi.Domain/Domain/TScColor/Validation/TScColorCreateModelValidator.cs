using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TScColorCreateModel"/> .
    /// </summary>
    public partial class TScColorCreateModelValidator
        : AbstractValidator<TScColorCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScColorCreateModelValidator"/> class.
        /// </summary>
        public TScColorCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NormalCoilColor).MaximumLength(10);
            RuleFor(p => p.SelectedCoilColor).MaximumLength(10);
            RuleFor(p => p.PlanCoilColor).MaximumLength(10);
            RuleFor(p => p.LockedCoilColor).MaximumLength(10);
            RuleFor(p => p.NormalLocationColor).MaximumLength(10);
            RuleFor(p => p.SelectedLocationColor).MaximumLength(10);
            RuleFor(p => p.Name).MaximumLength(255);
            #endregion
        }

    }
}
