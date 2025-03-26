using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlProductionDetailUpdateModel"/> .
    /// </summary>
    public partial class TPlProductionDetailUpdateModelValidator
        : AbstractValidator<TPlProductionDetailUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlProductionDetailUpdateModelValidator"/> class.
        /// </summary>
        public TPlProductionDetailUpdateModelValidator()
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
