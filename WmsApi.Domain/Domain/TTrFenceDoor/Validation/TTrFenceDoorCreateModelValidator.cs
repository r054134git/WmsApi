using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrFenceDoorCreateModel"/> .
    /// </summary>
    public partial class TTrFenceDoorCreateModelValidator
        : AbstractValidator<TTrFenceDoorCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrFenceDoorCreateModelValidator"/> class.
        /// </summary>
        public TTrFenceDoorCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FenceId).NotEmpty();
            RuleFor(p => p.FenceId).MaximumLength(32);
            RuleFor(p => p.FenceDoorId).NotEmpty();
            RuleFor(p => p.FenceDoorId).MaximumLength(32);
            RuleFor(p => p.FenceDoorCode).MaximumLength(50);
            RuleFor(p => p.RequestUser).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
