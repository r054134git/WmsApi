using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcTrainNodeCreateModel"/> .
    /// </summary>
    public partial class TRcTrainNodeCreateModelValidator
        : AbstractValidator<TRcTrainNodeCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTrainNodeCreateModelValidator"/> class.
        /// </summary>
        public TRcTrainNodeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TrainName).NotEmpty();
            RuleFor(p => p.TrainName).MaximumLength(255);
            RuleFor(p => p.NodeName).MaximumLength(255);
            #endregion
        }

    }
}
