using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckQueueInBayOutCreateModel"/> .
    /// </summary>
    public partial class TPlTruckQueueInBayOutCreateModelValidator
        : AbstractValidator<TPlTruckQueueInBayOutCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckQueueInBayOutCreateModelValidator"/> class.
        /// </summary>
        public TPlTruckQueueInBayOutCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OperationMark).MaximumLength(15);
            RuleFor(p => p.TruckLoadingNo).MaximumLength(50);
            RuleFor(p => p.DoorNo).MaximumLength(15);
            RuleFor(p => p.OrderNo).NotEmpty();
            RuleFor(p => p.OrderNo).MaximumLength(20);
            RuleFor(p => p.DetailNo).MaximumLength(15);
            RuleFor(p => p.No).NotEmpty();
            RuleFor(p => p.No).MaximumLength(20);
            RuleFor(p => p.Location).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
