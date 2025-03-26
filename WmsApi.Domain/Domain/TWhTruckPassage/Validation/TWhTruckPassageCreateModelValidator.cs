using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhTruckPassageCreateModel"/> .
    /// </summary>
    public partial class TWhTruckPassageCreateModelValidator
        : AbstractValidator<TWhTruckPassageCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTruckPassageCreateModelValidator"/> class.
        /// </summary>
        public TWhTruckPassageCreateModelValidator()
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
