using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlDeliveryPlanUpdateModel"/> .
    /// </summary>
    public partial class TPlDeliveryPlanUpdateModelValidator
        : AbstractValidator<TPlDeliveryPlanUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlDeliveryPlanUpdateModelValidator"/> class.
        /// </summary>
        public TPlDeliveryPlanUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.House).MaximumLength(10);
            RuleFor(p => p.OrderNo).MaximumLength(15);
            RuleFor(p => p.PlanDate).MaximumLength(8);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
