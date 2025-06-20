using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckLoadListCreateModel"/> .
    /// </summary>
    public partial class TPlTruckLoadListCreateModelValidator
        : AbstractValidator<TPlTruckLoadListCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckLoadListCreateModelValidator"/> class.
        /// </summary>
        public TPlTruckLoadListCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OperationMark).MaximumLength(1);
            RuleFor(p => p.CardNo).MaximumLength(20);
            RuleFor(p => p.TruckLoadingNo).MaximumLength(15);
            RuleFor(p => p.MainTruckLoadingNo).MaximumLength(15);
            RuleFor(p => p.VehicleNo).MaximumLength(10);
            RuleFor(p => p.SourceHouse).MaximumLength(10);
            RuleFor(p => p.DeliveryOrderNo).MaximumLength(13);
            RuleFor(p => p.ReplyInfo).MaximumLength(500);
            RuleFor(p => p.OrderNo).NotEmpty();
            RuleFor(p => p.OrderNo).MaximumLength(20);
            RuleFor(p => p.DetailNo).MaximumLength(15);
            RuleFor(p => p.Count).MaximumLength(9);
            RuleFor(p => p.Operator).MaximumLength(8);
            RuleFor(p => p.AutoPreHint).MaximumLength(200);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
