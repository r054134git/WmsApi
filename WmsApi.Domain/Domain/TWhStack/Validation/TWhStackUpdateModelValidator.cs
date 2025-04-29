using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhStackUpdateModel"/> .
    /// </summary>
    public partial class TWhStackUpdateModelValidator
        : AbstractValidator<TWhStackUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhStackUpdateModelValidator"/> class.
        /// </summary>
        public TWhStackUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(50);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.AreaNo).MaximumLength(10);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
