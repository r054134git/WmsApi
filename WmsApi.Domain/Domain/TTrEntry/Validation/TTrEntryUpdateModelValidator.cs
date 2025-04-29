using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrEntryUpdateModel"/> .
    /// </summary>
    public partial class TTrEntryUpdateModelValidator
        : AbstractValidator<TTrEntryUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrEntryUpdateModelValidator"/> class.
        /// </summary>
        public TTrEntryUpdateModelValidator()
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
