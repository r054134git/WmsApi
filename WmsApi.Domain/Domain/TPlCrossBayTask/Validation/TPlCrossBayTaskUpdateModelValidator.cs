using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlCrossBayTaskUpdateModel"/> .
    /// </summary>
    public partial class TPlCrossBayTaskUpdateModelValidator
        : AbstractValidator<TPlCrossBayTaskUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlCrossBayTaskUpdateModelValidator"/> class.
        /// </summary>
        public TPlCrossBayTaskUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TaskNo).NotEmpty();
            RuleFor(p => p.TaskNo).MaximumLength(30);
            RuleFor(p => p.VehicleId).NotEmpty();
            RuleFor(p => p.VehicleId).MaximumLength(32);
            RuleFor(p => p.VehicleName).NotEmpty();
            RuleFor(p => p.VehicleName).MaximumLength(32);
            RuleFor(p => p.FromBayId).NotEmpty();
            RuleFor(p => p.FromBayId).MaximumLength(32);
            RuleFor(p => p.FromBayName).NotEmpty();
            RuleFor(p => p.FromBayName).MaximumLength(30);
            RuleFor(p => p.DestBayId).NotEmpty();
            RuleFor(p => p.DestBayId).MaximumLength(32);
            RuleFor(p => p.DestBayName).NotEmpty();
            RuleFor(p => p.DestBayName).MaximumLength(30);
            RuleFor(p => p.MaterialNoPlan).MaximumLength(500);
            RuleFor(p => p.MaterialNoLoaded).MaximumLength(500);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
