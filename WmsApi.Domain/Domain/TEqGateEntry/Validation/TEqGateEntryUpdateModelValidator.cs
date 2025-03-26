using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqGateEntryUpdateModel"/> .
    /// </summary>
    public partial class TEqGateEntryUpdateModelValidator
        : AbstractValidator<TEqGateEntryUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqGateEntryUpdateModelValidator"/> class.
        /// </summary>
        public TEqGateEntryUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Code).MaximumLength(255);
            RuleFor(p => p.GateId).MaximumLength(255);
            RuleFor(p => p.IpGate).MaximumLength(255);
            RuleFor(p => p.IpLed).MaximumLength(255);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.EntryBayIdList).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
