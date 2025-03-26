using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrTrafficLightUpdateModel"/> .
    /// </summary>
    public partial class TTrTrafficLightUpdateModelValidator
        : AbstractValidator<TTrTrafficLightUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTrafficLightUpdateModelValidator"/> class.
        /// </summary>
        public TTrTrafficLightUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(32);
            RuleFor(p => p.PlcName).MaximumLength(32);
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
