using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcClassStockUpdateModel"/> .
    /// </summary>
    public partial class TRcClassStockUpdateModelValidator
        : AbstractValidator<TRcClassStockUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcClassStockUpdateModelValidator"/> class.
        /// </summary>
        public TRcClassStockUpdateModelValidator()
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
