using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrMessageSendUpdateModel"/> .
    /// </summary>
    public partial class TTrMessageSendUpdateModelValidator
        : AbstractValidator<TTrMessageSendUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrMessageSendUpdateModelValidator"/> class.
        /// </summary>
        public TTrMessageSendUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MessageId).NotEmpty();
            RuleFor(p => p.MessageId).MaximumLength(30);
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.FromLocation).MaximumLength(255);
            RuleFor(p => p.DestLocation).MaximumLength(255);
            RuleFor(p => p.BusinessName).MaximumLength(255);
            RuleFor(p => p.Area).MaximumLength(255);
            RuleFor(p => p.Row).MaximumLength(50);
            RuleFor(p => p.Col).MaximumLength(50);
            RuleFor(p => p.Floor).MaximumLength(1);
            RuleFor(p => p.Type).MaximumLength(255);
            RuleFor(p => p.Operator).MaximumLength(255);
            RuleFor(p => p.ReturnType).MaximumLength(255);
            RuleFor(p => p.ReturnReason).MaximumLength(255);
            RuleFor(p => p.BayCode).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
