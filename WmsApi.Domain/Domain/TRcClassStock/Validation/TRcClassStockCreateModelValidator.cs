using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcClassStockCreateModel"/> .
    /// </summary>
    public partial class TRcClassStockCreateModelValidator
        : AbstractValidator<TRcClassStockCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcClassStockCreateModelValidator"/> class.
        /// </summary>
        public TRcClassStockCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.HouseNo).MaximumLength(5);
            RuleFor(p => p.BayCode).MaximumLength(5);
            RuleFor(p => p.CurrentClasses).MaximumLength(5);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
