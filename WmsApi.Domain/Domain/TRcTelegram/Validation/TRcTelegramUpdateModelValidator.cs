using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcTelegramUpdateModel"/> .
    /// </summary>
    public partial class TRcTelegramUpdateModelValidator
        : AbstractValidator<TRcTelegramUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTelegramUpdateModelValidator"/> class.
        /// </summary>
        public TRcTelegramUpdateModelValidator()
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
