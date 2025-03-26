using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrTruckQueueUpdateModel"/> .
    /// </summary>
    public partial class TTrTruckQueueUpdateModelValidator
        : AbstractValidator<TTrTruckQueueUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTruckQueueUpdateModelValidator"/> class.
        /// </summary>
        public TTrTruckQueueUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TruckCode).NotEmpty();
            RuleFor(p => p.TruckCode).MaximumLength(30);
            RuleFor(p => p.ListNo).NotEmpty();
            RuleFor(p => p.ListNo).MaximumLength(30);
            RuleFor(p => p.DispatchParkingPlaceId).MaximumLength(32);
            RuleFor(p => p.DispatchBayId).MaximumLength(32);
            RuleFor(p => p.EntryBayIdList).MaximumLength(255);
            RuleFor(p => p.EntryBayId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
