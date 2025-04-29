using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmPermissionCreateModel"/> .
    /// </summary>
    public partial class TUmPermissionCreateModelValidator
        : AbstractValidator<TUmPermissionCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmPermissionCreateModelValidator"/> class.
        /// </summary>
        public TUmPermissionCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Seq).NotEmpty();
            RuleFor(p => p.Seq).MaximumLength(255);
            RuleFor(p => p.Key).NotEmpty();
            RuleFor(p => p.Key).MaximumLength(255);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
