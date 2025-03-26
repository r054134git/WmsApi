using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrEntryCreateModel"/> .
    /// </summary>
    public partial class TTrEntryCreateModelValidator
        : AbstractValidator<TTrEntryCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrEntryCreateModelValidator"/> class.
        /// </summary>
        public TTrEntryCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.GateId).NotEmpty();
            RuleFor(p => p.GateId).MaximumLength(32);
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Code).MaximumLength(255);
            RuleFor(p => p.LedContent).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
