using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrFenceAreaUpdateModel"/> .
    /// </summary>
    public partial class TTrFenceAreaUpdateModelValidator
        : AbstractValidator<TTrFenceAreaUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrFenceAreaUpdateModelValidator"/> class.
        /// </summary>
        public TTrFenceAreaUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FenceId).NotEmpty();
            RuleFor(p => p.FenceId).MaximumLength(32);
            RuleFor(p => p.FenceUsers).MaximumLength(255);
            RuleFor(p => p.BayId).NotEmpty();
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
