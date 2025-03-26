using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlDeliveryPlanCreateModel"/> .
    /// </summary>
    public partial class TPlDeliveryPlanCreateModelValidator
        : AbstractValidator<TPlDeliveryPlanCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlDeliveryPlanCreateModelValidator"/> class.
        /// </summary>
        public TPlDeliveryPlanCreateModelValidator()
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
