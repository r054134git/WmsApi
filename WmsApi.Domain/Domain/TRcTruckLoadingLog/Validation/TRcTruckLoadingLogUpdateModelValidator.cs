using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcTruckLoadingLogUpdateModel"/> .
    /// </summary>
    public partial class TRcTruckLoadingLogUpdateModelValidator
        : AbstractValidator<TRcTruckLoadingLogUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTruckLoadingLogUpdateModelValidator"/> class.
        /// </summary>
        public TRcTruckLoadingLogUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayCode).MaximumLength(5);
            RuleFor(p => p.ParkingPlace).MaximumLength(5);
            RuleFor(p => p.TruckNo).MaximumLength(10);
            RuleFor(p => p.MainTruckLoadingNo).MaximumLength(15);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
