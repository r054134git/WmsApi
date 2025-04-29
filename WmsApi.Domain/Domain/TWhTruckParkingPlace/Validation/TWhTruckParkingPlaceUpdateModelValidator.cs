using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhTruckParkingPlaceUpdateModel"/> .
    /// </summary>
    public partial class TWhTruckParkingPlaceUpdateModelValidator
        : AbstractValidator<TWhTruckParkingPlaceUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTruckParkingPlaceUpdateModelValidator"/> class.
        /// </summary>
        public TWhTruckParkingPlaceUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Code).MaximumLength(255);
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.BayCode).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
