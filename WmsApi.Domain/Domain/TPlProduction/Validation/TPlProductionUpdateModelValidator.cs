using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlProductionUpdateModel"/> .
    /// </summary>
    public partial class TPlProductionUpdateModelValidator
        : AbstractValidator<TPlProductionUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlProductionUpdateModelValidator"/> class.
        /// </summary>
        public TPlProductionUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ProductionNo).MaximumLength(32);
            RuleFor(p => p.PlanState).MaximumLength(5);
            RuleFor(p => p.UnitNo).MaximumLength(5);
            RuleFor(p => p.NextProcessId).MaximumLength(32);
            RuleFor(p => p.OrderNo).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
