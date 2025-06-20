using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrConveyingChainUpdateModel"/> .
    /// </summary>
    public partial class TTrConveyingChainUpdateModelValidator
        : AbstractValidator<TTrConveyingChainUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrConveyingChainUpdateModelValidator"/> class.
        /// </summary>
        public TTrConveyingChainUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.LocationId).MaximumLength(32);
            RuleFor(p => p.ConveyorId).MaximumLength(32);
            #endregion
        }

    }
}
