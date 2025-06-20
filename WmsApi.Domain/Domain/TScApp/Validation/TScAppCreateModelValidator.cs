using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TScAppCreateModel"/> .
    /// </summary>
    public partial class TScAppCreateModelValidator
        : AbstractValidator<TScAppCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScAppCreateModelValidator"/> class.
        /// </summary>
        public TScAppCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.AppType).NotEmpty();
            RuleFor(p => p.AppType).MaximumLength(32);
            RuleFor(p => p.AppVersion).NotEmpty();
            RuleFor(p => p.AppVersion).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
