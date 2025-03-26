using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcLogCreateModel"/> .
    /// </summary>
    public partial class TRcLogCreateModelValidator
        : AbstractValidator<TRcLogCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLogCreateModelValidator"/> class.
        /// </summary>
        public TRcLogCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.EventNo).NotEmpty();
            RuleFor(p => p.EventNo).MaximumLength(255);
            RuleFor(p => p.WarningLevel).NotEmpty();
            RuleFor(p => p.WarningLevel).MaximumLength(255);
            RuleFor(p => p.Message).NotEmpty();
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.Source).NotEmpty();
            RuleFor(p => p.Source).MaximumLength(30);
            #endregion
        }

    }
}
