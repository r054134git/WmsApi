using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcInventoryUpdateModel"/> .
    /// </summary>
    public partial class TRcInventoryUpdateModelValidator
        : AbstractValidator<TRcInventoryUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcInventoryUpdateModelValidator"/> class.
        /// </summary>
        public TRcInventoryUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.PlanNo).NotEmpty();
            RuleFor(p => p.PlanNo).MaximumLength(20);
            RuleFor(p => p.UserAccount).NotEmpty();
            RuleFor(p => p.UserAccount).MaximumLength(20);
            RuleFor(p => p.UserName).NotEmpty();
            RuleFor(p => p.UserName).MaximumLength(20);
            RuleFor(p => p.BayCode).NotEmpty();
            RuleFor(p => p.BayCode).MaximumLength(20);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
