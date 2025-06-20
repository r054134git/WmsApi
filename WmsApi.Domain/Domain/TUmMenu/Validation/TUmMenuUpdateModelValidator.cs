using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmMenuUpdateModel"/> .
    /// </summary>
    public partial class TUmMenuUpdateModelValidator
        : AbstractValidator<TUmMenuUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmMenuUpdateModelValidator"/> class.
        /// </summary>
        public TUmMenuUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(255);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Path).MaximumLength(255);
            RuleFor(p => p.Icon).MaximumLength(255);
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
