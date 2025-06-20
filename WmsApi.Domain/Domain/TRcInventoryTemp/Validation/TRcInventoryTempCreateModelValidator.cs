using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcInventoryTempCreateModel"/> .
    /// </summary>
    public partial class TRcInventoryTempCreateModelValidator
        : AbstractValidator<TRcInventoryTempCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcInventoryTempCreateModelValidator"/> class.
        /// </summary>
        public TRcInventoryTempCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.PlanNo).NotEmpty();
            RuleFor(p => p.PlanNo).MaximumLength(32);
            RuleFor(p => p.BayId).NotEmpty();
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.BayCode).MaximumLength(30);
            RuleFor(p => p.LocationName).MaximumLength(255);
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
