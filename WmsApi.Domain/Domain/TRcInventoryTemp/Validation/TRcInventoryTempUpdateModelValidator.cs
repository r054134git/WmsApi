using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcInventoryTempUpdateModel"/> .
    /// </summary>
    public partial class TRcInventoryTempUpdateModelValidator
        : AbstractValidator<TRcInventoryTempUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcInventoryTempUpdateModelValidator"/> class.
        /// </summary>
        public TRcInventoryTempUpdateModelValidator()
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
