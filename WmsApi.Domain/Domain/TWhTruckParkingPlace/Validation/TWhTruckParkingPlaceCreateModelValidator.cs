using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhTruckParkingPlaceCreateModel"/> .
    /// </summary>
    public partial class TWhTruckParkingPlaceCreateModelValidator
        : AbstractValidator<TWhTruckParkingPlaceCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTruckParkingPlaceCreateModelValidator"/> class.
        /// </summary>
        public TWhTruckParkingPlaceCreateModelValidator()
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
