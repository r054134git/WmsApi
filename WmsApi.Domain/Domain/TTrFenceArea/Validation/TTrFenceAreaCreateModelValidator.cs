using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrFenceAreaCreateModel"/> .
    /// </summary>
    public partial class TTrFenceAreaCreateModelValidator
        : AbstractValidator<TTrFenceAreaCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrFenceAreaCreateModelValidator"/> class.
        /// </summary>
        public TTrFenceAreaCreateModelValidator()
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
