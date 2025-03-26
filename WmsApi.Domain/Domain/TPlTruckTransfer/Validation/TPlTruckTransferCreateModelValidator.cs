using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckTransferCreateModel"/> .
    /// </summary>
    public partial class TPlTruckTransferCreateModelValidator
        : AbstractValidator<TPlTruckTransferCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckTransferCreateModelValidator"/> class.
        /// </summary>
        public TPlTruckTransferCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OperationMark).MaximumLength(1);
            RuleFor(p => p.TransferNo).MaximumLength(15);
            RuleFor(p => p.OrderNo).MaximumLength(20);
            RuleFor(p => p.CardNo).MaximumLength(20);
            RuleFor(p => p.TruckNo).MaximumLength(10);
            RuleFor(p => p.SourceHouse).MaximumLength(5);
            RuleFor(p => p.FakeLoadingNo).MaximumLength(15);
            RuleFor(p => p.DestHouse).MaximumLength(5);
            RuleFor(p => p.IsSpecifyCoilNo).MaximumLength(1);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
