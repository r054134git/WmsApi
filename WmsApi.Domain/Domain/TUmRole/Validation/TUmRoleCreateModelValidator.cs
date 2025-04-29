using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmRoleCreateModel"/> .
    /// </summary>
    public partial class TUmRoleCreateModelValidator
        : AbstractValidator<TUmRoleCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmRoleCreateModelValidator"/> class.
        /// </summary>
        public TUmRoleCreateModelValidator()
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
