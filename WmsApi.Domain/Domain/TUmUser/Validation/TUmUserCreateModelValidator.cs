using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmUserCreateModel"/> .
    /// </summary>
    public partial class TUmUserCreateModelValidator
        : AbstractValidator<TUmUserCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmUserCreateModelValidator"/> class.
        /// </summary>
        public TUmUserCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Account).NotEmpty();
            RuleFor(p => p.Account).MaximumLength(255);
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).MaximumLength(64);
            RuleFor(p => p.TeamId).NotEmpty();
            RuleFor(p => p.TeamId).MaximumLength(32);
            RuleFor(p => p.Department).MaximumLength(30);
            RuleFor(p => p.RoleId).NotEmpty();
            RuleFor(p => p.RoleId).MaximumLength(32);
            RuleFor(p => p.BayIdNameList).MaximumLength(1024);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
