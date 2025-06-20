using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrMessageReceivedUpdateModel"/> .
    /// </summary>
    public partial class TTrMessageReceivedUpdateModelValidator
        : AbstractValidator<TTrMessageReceivedUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrMessageReceivedUpdateModelValidator"/> class.
        /// </summary>
        public TTrMessageReceivedUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MessageId).NotEmpty();
            RuleFor(p => p.MessageId).MaximumLength(30);
            RuleFor(p => p.MessageContent).NotEmpty();
            RuleFor(p => p.MessageContent).MaximumLength(4096);
            RuleFor(p => p.SummaryInfo).MaximumLength(50);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
