using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrTrainUpdateModel"/> .
    /// </summary>
    public partial class TTrTrainUpdateModelValidator
        : AbstractValidator<TTrTrainUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTrainUpdateModelValidator"/> class.
        /// </summary>
        public TTrTrainUpdateModelValidator()
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
