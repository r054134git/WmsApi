using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmRolePermissionCreateModel"/> .
    /// </summary>
    public partial class TUmRolePermissionCreateModelValidator
        : AbstractValidator<TUmRolePermissionCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmRolePermissionCreateModelValidator"/> class.
        /// </summary>
        public TUmRolePermissionCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.RoleId).MaximumLength(32);
            RuleFor(p => p.PermissionId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
