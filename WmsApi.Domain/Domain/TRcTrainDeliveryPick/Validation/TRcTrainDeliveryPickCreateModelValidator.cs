using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcTrainDeliveryPickCreateModel"/> .
    /// </summary>
    public partial class TRcTrainDeliveryPickCreateModelValidator
        : AbstractValidator<TRcTrainDeliveryPickCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTrainDeliveryPickCreateModelValidator"/> class.
        /// </summary>
        public TRcTrainDeliveryPickCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OperationMark).MaximumLength(1);
            RuleFor(p => p.SourceHouse).MaximumLength(3);
            RuleFor(p => p.TargetHouse).MaximumLength(10);
            RuleFor(p => p.TargetHouseType).MaximumLength(11);
            RuleFor(p => p.Code).MaximumLength(1);
            RuleFor(p => p.CoilNo).NotEmpty();
            RuleFor(p => p.CoilNo).MaximumLength(20);
            RuleFor(p => p.CoilType).MaximumLength(10);
            RuleFor(p => p.TrainId).MaximumLength(32);
            RuleFor(p => p.TrainNo).MaximumLength(10);
            RuleFor(p => p.TrainLocationNo).MaximumLength(20);
            RuleFor(p => p.Operator).MaximumLength(10);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
