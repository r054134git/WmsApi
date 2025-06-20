using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlBackRepackUpdateModel"/> .
    /// </summary>
    public partial class TPlBackRepackUpdateModelValidator
        : AbstractValidator<TPlBackRepackUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBackRepackUpdateModelValidator"/> class.
        /// </summary>
        public TPlBackRepackUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MaterialNo).NotEmpty();
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.PackCode).NotEmpty();
            RuleFor(p => p.PackCode).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
