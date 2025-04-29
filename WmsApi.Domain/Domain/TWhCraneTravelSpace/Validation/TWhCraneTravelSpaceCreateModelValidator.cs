using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhCraneTravelSpaceCreateModel"/> .
    /// </summary>
    public partial class TWhCraneTravelSpaceCreateModelValidator
        : AbstractValidator<TWhCraneTravelSpaceCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhCraneTravelSpaceCreateModelValidator"/> class.
        /// </summary>
        public TWhCraneTravelSpaceCreateModelValidator()
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
