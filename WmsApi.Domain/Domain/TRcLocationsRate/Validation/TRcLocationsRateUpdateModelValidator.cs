using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcLocationsRateUpdateModel"/> .
    /// </summary>
    public partial class TRcLocationsRateUpdateModelValidator
        : AbstractValidator<TRcLocationsRateUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLocationsRateUpdateModelValidator"/> class.
        /// </summary>
        public TRcLocationsRateUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayCode).NotEmpty();
            RuleFor(p => p.BayCode).MaximumLength(2);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
