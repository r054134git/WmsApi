using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcLocationsRateCreateModel"/> .
    /// </summary>
    public partial class TRcLocationsRateCreateModelValidator
        : AbstractValidator<TRcLocationsRateCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLocationsRateCreateModelValidator"/> class.
        /// </summary>
        public TRcLocationsRateCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayCode).NotEmpty();
            RuleFor(p => p.BayCode).MaximumLength(2);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
