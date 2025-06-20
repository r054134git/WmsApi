using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhCraneTravelSpaceUpdateModel"/> .
    /// </summary>
    public partial class TWhCraneTravelSpaceUpdateModelValidator
        : AbstractValidator<TWhCraneTravelSpaceUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhCraneTravelSpaceUpdateModelValidator"/> class.
        /// </summary>
        public TWhCraneTravelSpaceUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
