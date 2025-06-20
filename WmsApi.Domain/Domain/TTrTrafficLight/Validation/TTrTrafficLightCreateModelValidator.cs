using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrTrafficLightCreateModel"/> .
    /// </summary>
    public partial class TTrTrafficLightCreateModelValidator
        : AbstractValidator<TTrTrafficLightCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTrafficLightCreateModelValidator"/> class.
        /// </summary>
        public TTrTrafficLightCreateModelValidator()
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
