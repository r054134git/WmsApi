using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="VCompareCreateModel"/> .
    /// </summary>
    public partial class VCompareCreateModelValidator
        : AbstractValidator<VCompareCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCompareCreateModelValidator"/> class.
        /// </summary>
        public VCompareCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LocationNameWms).NotEmpty();
            RuleFor(p => p.LocationNameWms).MaximumLength(255);
            RuleFor(p => p.LocationNameMes).MaximumLength(15);
            RuleFor(p => p.MatNoWms).MaximumLength(30);
            RuleFor(p => p.MatNoMes).MaximumLength(20);
            RuleFor(p => p.BayIdWms).NotEmpty();
            RuleFor(p => p.BayIdWms).MaximumLength(32);
            RuleFor(p => p.StockNoWms).NotEmpty();
            RuleFor(p => p.StockNoWms).MaximumLength(32);
            RuleFor(p => p.StockNoMes).MaximumLength(3);
            #endregion
        }

    }
}
