using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcTruckLoadingLogCreateModel"/> .
    /// </summary>
    public partial class TRcTruckLoadingLogCreateModelValidator
        : AbstractValidator<TRcTruckLoadingLogCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTruckLoadingLogCreateModelValidator"/> class.
        /// </summary>
        public TRcTruckLoadingLogCreateModelValidator()
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
