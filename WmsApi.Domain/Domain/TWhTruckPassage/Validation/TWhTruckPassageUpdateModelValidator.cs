using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhTruckPassageUpdateModel"/> .
    /// </summary>
    public partial class TWhTruckPassageUpdateModelValidator
        : AbstractValidator<TWhTruckPassageUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTruckPassageUpdateModelValidator"/> class.
        /// </summary>
        public TWhTruckPassageUpdateModelValidator()
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
