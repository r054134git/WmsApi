using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrParkingPlaceUpdateModel"/> .
    /// </summary>
    public partial class TTrParkingPlaceUpdateModelValidator
        : AbstractValidator<TTrParkingPlaceUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrParkingPlaceUpdateModelValidator"/> class.
        /// </summary>
        public TTrParkingPlaceUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ParkingPlaceId).NotEmpty();
            RuleFor(p => p.ParkingPlaceId).MaximumLength(32);
            RuleFor(p => p.BayCode).NotEmpty();
            RuleFor(p => p.BayCode).MaximumLength(30);
            RuleFor(p => p.ParkingPlaceName).NotEmpty();
            RuleFor(p => p.ParkingPlaceName).MaximumLength(32);
            RuleFor(p => p.TransCode).MaximumLength(255);
            RuleFor(p => p.CandidateTruck).MaximumLength(50);
            RuleFor(p => p.GateId).NotEmpty();
            RuleFor(p => p.GateId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
