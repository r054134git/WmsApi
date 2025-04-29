using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrTrainCreateModel"/> .
    /// </summary>
    public partial class TTrTrainCreateModelValidator
        : AbstractValidator<TTrTrainCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTrainCreateModelValidator"/> class.
        /// </summary>
        public TTrTrainCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TrainId).MaximumLength(32);
            RuleFor(p => p.HouseId).MaximumLength(32);
            RuleFor(p => p.PositionId).MaximumLength(32);
            RuleFor(p => p.DestHouse).MaximumLength(10);
            RuleFor(p => p.SourceHouse).MaximumLength(10);
            RuleFor(p => p.TrainNo).MaximumLength(10);
            RuleFor(p => p.BeforeTrainId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
