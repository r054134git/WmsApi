using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTestPreUpdateModel"/> .
    /// </summary>
    public partial class TTestPreUpdateModelValidator
        : AbstractValidator<TTestPreUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTestPreUpdateModelValidator"/> class.
        /// </summary>
        public TTestPreUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.LocationName).MaximumLength(30);
            RuleFor(p => p.BayCode).MaximumLength(5);
            #endregion
        }

    }
}
