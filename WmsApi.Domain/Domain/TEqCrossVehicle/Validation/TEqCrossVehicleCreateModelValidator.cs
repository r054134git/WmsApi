using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqCrossVehicleCreateModel"/> .
    /// </summary>
    public partial class TEqCrossVehicleCreateModelValidator
        : AbstractValidator<TEqCrossVehicleCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCrossVehicleCreateModelValidator"/> class.
        /// </summary>
        public TEqCrossVehicleCreateModelValidator()
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
