using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrCraneCreateModel"/> .
    /// </summary>
    public partial class TTrCraneCreateModelValidator
        : AbstractValidator<TTrCraneCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCraneCreateModelValidator"/> class.
        /// </summary>
        public TTrCraneCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CraneId).MaximumLength(32);
            RuleFor(p => p.CraneName).MaximumLength(32);
            RuleFor(p => p.CranePlcName).MaximumLength(32);
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.LoadLocationName).MaximumLength(255);
            RuleFor(p => p.TargetLocationName).MaximumLength(255);
            RuleFor(p => p.TargetLocationTips).MaximumLength(255);
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.MaterialIdByUser).MaximumLength(32);
            RuleFor(p => p.MaterialNoByUser).MaximumLength(30);
            RuleFor(p => p.LoadableCoils).MaximumLength(4000);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
