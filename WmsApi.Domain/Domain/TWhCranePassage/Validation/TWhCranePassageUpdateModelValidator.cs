using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhCranePassageUpdateModel"/> .
    /// </summary>
    public partial class TWhCranePassageUpdateModelValidator
        : AbstractValidator<TWhCranePassageUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhCranePassageUpdateModelValidator"/> class.
        /// </summary>
        public TWhCranePassageUpdateModelValidator()
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
