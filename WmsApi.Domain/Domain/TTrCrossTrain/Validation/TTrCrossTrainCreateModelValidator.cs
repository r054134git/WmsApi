using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrCrossTrainCreateModel"/> .
    /// </summary>
    public partial class TTrCrossTrainCreateModelValidator
        : AbstractValidator<TTrCrossTrainCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCrossTrainCreateModelValidator"/> class.
        /// </summary>
        public TTrCrossTrainCreateModelValidator()
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
