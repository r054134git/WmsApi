using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTestPreCreateModel"/> .
    /// </summary>
    public partial class TTestPreCreateModelValidator
        : AbstractValidator<TTestPreCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTestPreCreateModelValidator"/> class.
        /// </summary>
        public TTestPreCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.LocationName).MaximumLength(30);
            RuleFor(p => p.BayCode).MaximumLength(5);
            #endregion
        }

    }
}
