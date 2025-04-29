using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckQueueInBayShiftUpdateModel"/> .
    /// </summary>
    public partial class TPlTruckQueueInBayShiftUpdateModelValidator
        : AbstractValidator<TPlTruckQueueInBayShiftUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckQueueInBayShiftUpdateModelValidator"/> class.
        /// </summary>
        public TPlTruckQueueInBayShiftUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OperationMark).MaximumLength(1);
            RuleFor(p => p.OutHouse).MaximumLength(5);
            RuleFor(p => p.CardNo).MaximumLength(20);
            RuleFor(p => p.VehicleNo).MaximumLength(10);
            RuleFor(p => p.ArriveNo).MaximumLength(30);
            RuleFor(p => p.TruckLoadingNo).MaximumLength(15);
            RuleFor(p => p.EntryHouse).MaximumLength(5);
            RuleFor(p => p.OrderNo).NotEmpty();
            RuleFor(p => p.OrderNo).MaximumLength(20);
            RuleFor(p => p.DetailNo).MaximumLength(15);
            RuleFor(p => p.No).NotEmpty();
            RuleFor(p => p.No).MaximumLength(20);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
