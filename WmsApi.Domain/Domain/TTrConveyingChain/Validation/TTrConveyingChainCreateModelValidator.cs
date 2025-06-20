using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrConveyingChainCreateModel"/> .
    /// </summary>
    public partial class TTrConveyingChainCreateModelValidator
        : AbstractValidator<TTrConveyingChainCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrConveyingChainCreateModelValidator"/> class.
        /// </summary>
        public TTrConveyingChainCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.LocationId).MaximumLength(32);
            RuleFor(p => p.ConveyorId).MaximumLength(32);
            #endregion
        }

    }
}
