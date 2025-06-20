using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlProductionCreateModel"/> .
    /// </summary>
    public partial class TPlProductionCreateModelValidator
        : AbstractValidator<TPlProductionCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlProductionCreateModelValidator"/> class.
        /// </summary>
        public TPlProductionCreateModelValidator()
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
