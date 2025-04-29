using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcInventoryDetailUpdateModel"/> .
    /// </summary>
    public partial class TRcInventoryDetailUpdateModelValidator
        : AbstractValidator<TRcInventoryDetailUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcInventoryDetailUpdateModelValidator"/> class.
        /// </summary>
        public TRcInventoryDetailUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.PlanId).NotEmpty();
            RuleFor(p => p.PlanId).MaximumLength(32);
            RuleFor(p => p.MaterialNo).NotEmpty();
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.BundleNo).MaximumLength(30);
            RuleFor(p => p.WmsLocationName).MaximumLength(30);
            RuleFor(p => p.UserLocationName).MaximumLength(30);
            RuleFor(p => p.SystemComment).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
