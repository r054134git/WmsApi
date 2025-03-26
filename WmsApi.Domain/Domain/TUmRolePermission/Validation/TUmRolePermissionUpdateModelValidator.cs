using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmRolePermissionUpdateModel"/> .
    /// </summary>
    public partial class TUmRolePermissionUpdateModelValidator
        : AbstractValidator<TUmRolePermissionUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmRolePermissionUpdateModelValidator"/> class.
        /// </summary>
        public TUmRolePermissionUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.RoleId).MaximumLength(32);
            RuleFor(p => p.PermissionId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
