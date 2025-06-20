using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmRoleUpdateModel"/> .
    /// </summary>
    public partial class TUmRoleUpdateModelValidator
        : AbstractValidator<TUmRoleUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmRoleUpdateModelValidator"/> class.
        /// </summary>
        public TUmRoleUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
