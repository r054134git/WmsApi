using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlProductionDetailCreateModel"/> .
    /// </summary>
    public partial class TPlProductionDetailCreateModelValidator
        : AbstractValidator<TPlProductionDetailCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlProductionDetailCreateModelValidator"/> class.
        /// </summary>
        public TPlProductionDetailCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ProductionNo).MaximumLength(32);
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.MaterialNo).NotEmpty();
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
