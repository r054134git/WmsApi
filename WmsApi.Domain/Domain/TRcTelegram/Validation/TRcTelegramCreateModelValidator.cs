using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcTelegramCreateModel"/> .
    /// </summary>
    public partial class TRcTelegramCreateModelValidator
        : AbstractValidator<TRcTelegramCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTelegramCreateModelValidator"/> class.
        /// </summary>
        public TRcTelegramCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LocalCode).MaximumLength(255);
            RuleFor(p => p.PartnerCode).MaximumLength(10);
            RuleFor(p => p.TelegramId).MaximumLength(10);
            RuleFor(p => p.Content).MaximumLength(8000);
            RuleFor(p => p.Result).MaximumLength(10);
            RuleFor(p => p.Response).MaximumLength(1000);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
