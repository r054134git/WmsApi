using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcTruckCreateModel"/> .
    /// </summary>
    public partial class TRcTruckCreateModelValidator
        : AbstractValidator<TRcTruckCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTruckCreateModelValidator"/> class.
        /// </summary>
        public TRcTruckCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TruckNo).MaximumLength(20);
            RuleFor(p => p.CardNo).MaximumLength(20);
            RuleFor(p => p.MainTruckLoadingNo).MaximumLength(15);
            RuleFor(p => p.TruckBackNo).MaximumLength(20);
            RuleFor(p => p.TransferNo).MaximumLength(20);
            RuleFor(p => p.GateEntryCode).MaximumLength(255);
            RuleFor(p => p.GateEntryId).MaximumLength(255);
            RuleFor(p => p.LoadBussinessNameList).MaximumLength(255);
            RuleFor(p => p.LoadBayCodeList).MaximumLength(100);
            RuleFor(p => p.FinishBusinessNameList).MaximumLength(100);
            RuleFor(p => p.FinishBayCodeList).MaximumLength(100);
            RuleFor(p => p.ParkingNoSuggest).MaximumLength(20);
            RuleFor(p => p.ParkingNoCurrent).MaximumLength(20);
            RuleFor(p => p.Direction).MaximumLength(50);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
