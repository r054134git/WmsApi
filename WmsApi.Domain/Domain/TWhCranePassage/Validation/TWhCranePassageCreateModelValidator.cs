using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhCranePassageCreateModel"/> .
    /// </summary>
    public partial class TWhCranePassageCreateModelValidator
        : AbstractValidator<TWhCranePassageCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhCranePassageCreateModelValidator"/> class.
        /// </summary>
        public TWhCranePassageCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Code).MaximumLength(255);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
