using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlBackRepackCreateModel"/> .
    /// </summary>
    public partial class TPlBackRepackCreateModelValidator
        : AbstractValidator<TPlBackRepackCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBackRepackCreateModelValidator"/> class.
        /// </summary>
        public TPlBackRepackCreateModelValidator()
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
