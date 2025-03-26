using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhStackCreateModel"/> .
    /// </summary>
    public partial class TWhStackCreateModelValidator
        : AbstractValidator<TWhStackCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhStackCreateModelValidator"/> class.
        /// </summary>
        public TWhStackCreateModelValidator()
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
