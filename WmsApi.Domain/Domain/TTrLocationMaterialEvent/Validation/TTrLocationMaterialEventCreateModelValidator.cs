using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrLocationMaterialEventCreateModel"/> .
    /// </summary>
    public partial class TTrLocationMaterialEventCreateModelValidator
        : AbstractValidator<TTrLocationMaterialEventCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrLocationMaterialEventCreateModelValidator"/> class.
        /// </summary>
        public TTrLocationMaterialEventCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MaterialNo).MaximumLength(32);
            RuleFor(p => p.CraneName).MaximumLength(20);
            RuleFor(p => p.LoadLocationNo).MaximumLength(30);
            RuleFor(p => p.UnloadLocationNo).MaximumLength(30);
            RuleFor(p => p.BayName).MaximumLength(50);
            RuleFor(p => p.Description).MaximumLength(300);
            #endregion
        }

    }
}
