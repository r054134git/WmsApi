using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TScTransferTerminalUpdateModel"/> .
    /// </summary>
    public partial class TScTransferTerminalUpdateModelValidator
        : AbstractValidator<TScTransferTerminalUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScTransferTerminalUpdateModelValidator"/> class.
        /// </summary>
        public TScTransferTerminalUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CodeNumber).MaximumLength(20);
            RuleFor(p => p.Code).MaximumLength(100);
            RuleFor(p => p.CityName).MaximumLength(200);
            RuleFor(p => p.BelongCityName).MaximumLength(200);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
