using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckDeliveryDetailCreateModel"/> .
    /// </summary>
    public partial class TPlTruckDeliveryDetailCreateModelValidator
        : AbstractValidator<TPlTruckDeliveryDetailCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckDeliveryDetailCreateModelValidator"/> class.
        /// </summary>
        public TPlTruckDeliveryDetailCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CoilNo).MaximumLength(30);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
