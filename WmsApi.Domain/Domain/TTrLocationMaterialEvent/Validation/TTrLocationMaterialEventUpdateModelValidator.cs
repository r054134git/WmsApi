using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrLocationMaterialEventUpdateModel"/> .
    /// </summary>
    public partial class TTrLocationMaterialEventUpdateModelValidator
        : AbstractValidator<TTrLocationMaterialEventUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrLocationMaterialEventUpdateModelValidator"/> class.
        /// </summary>
        public TTrLocationMaterialEventUpdateModelValidator()
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
