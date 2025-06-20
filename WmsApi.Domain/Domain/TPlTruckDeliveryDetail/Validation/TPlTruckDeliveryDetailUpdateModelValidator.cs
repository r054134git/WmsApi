using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckDeliveryDetailUpdateModel"/> .
    /// </summary>
    public partial class TPlTruckDeliveryDetailUpdateModelValidator
        : AbstractValidator<TPlTruckDeliveryDetailUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckDeliveryDetailUpdateModelValidator"/> class.
        /// </summary>
        public TPlTruckDeliveryDetailUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CoilNo).MaximumLength(30);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
