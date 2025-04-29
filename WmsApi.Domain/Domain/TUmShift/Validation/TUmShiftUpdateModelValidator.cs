using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmShiftUpdateModel"/> .
    /// </summary>
    public partial class TUmShiftUpdateModelValidator
        : AbstractValidator<TUmShiftUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmShiftUpdateModelValidator"/> class.
        /// </summary>
        public TUmShiftUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
