using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrCrossTrainUpdateModel"/> .
    /// </summary>
    public partial class TTrCrossTrainUpdateModelValidator
        : AbstractValidator<TTrCrossTrainUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCrossTrainUpdateModelValidator"/> class.
        /// </summary>
        public TTrCrossTrainUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.VehicleId).NotEmpty();
            RuleFor(p => p.VehicleId).MaximumLength(32);
            RuleFor(p => p.VehicleName).NotEmpty();
            RuleFor(p => p.VehicleName).MaximumLength(32);
            RuleFor(p => p.VehiclePlcName).MaximumLength(32);
            RuleFor(p => p.FromBayName).MaximumLength(30);
            RuleFor(p => p.DestBayName).MaximumLength(30);
            RuleFor(p => p.StackId).MaximumLength(32);
            RuleFor(p => p.FaultDesc).MaximumLength(255);
            RuleFor(p => p.TaskNoWms).MaximumLength(30);
            RuleFor(p => p.TaskNoPlc).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
