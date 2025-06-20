using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmGroupUpdateModel"/> .
    /// </summary>
    public partial class TUmGroupUpdateModelValidator
        : AbstractValidator<TUmGroupUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmGroupUpdateModelValidator"/> class.
        /// </summary>
        public TUmGroupUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Area).NotEmpty();
            RuleFor(p => p.Area).MaximumLength(255);
            RuleFor(p => p.GafferName).NotEmpty();
            RuleFor(p => p.GafferName).MaximumLength(255);
            RuleFor(p => p.UserName).NotEmpty();
            RuleFor(p => p.UserName).MaximumLength(255);
            RuleFor(p => p.UserAccount).NotEmpty();
            RuleFor(p => p.UserAccount).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
