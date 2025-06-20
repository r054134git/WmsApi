using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqCrossVehicleUpdateModel"/> .
    /// </summary>
    public partial class TEqCrossVehicleUpdateModelValidator
        : AbstractValidator<TEqCrossVehicleUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCrossVehicleUpdateModelValidator"/> class.
        /// </summary>
        public TEqCrossVehicleUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(30);
            RuleFor(p => p.BayDistanceConfig).MaximumLength(4096);
            RuleFor(p => p.FenceAreaId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
