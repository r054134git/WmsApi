using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmMenuCreateModel"/> .
    /// </summary>
    public partial class TUmMenuCreateModelValidator
        : AbstractValidator<TUmMenuCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmMenuCreateModelValidator"/> class.
        /// </summary>
        public TUmMenuCreateModelValidator()
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
