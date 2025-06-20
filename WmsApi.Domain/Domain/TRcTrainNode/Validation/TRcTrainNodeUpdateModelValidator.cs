using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcTrainNodeUpdateModel"/> .
    /// </summary>
    public partial class TRcTrainNodeUpdateModelValidator
        : AbstractValidator<TRcTrainNodeUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTrainNodeUpdateModelValidator"/> class.
        /// </summary>
        public TRcTrainNodeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TrainName).NotEmpty();
            RuleFor(p => p.TrainName).MaximumLength(255);
            RuleFor(p => p.NodeName).MaximumLength(255);
            #endregion
        }

    }
}
