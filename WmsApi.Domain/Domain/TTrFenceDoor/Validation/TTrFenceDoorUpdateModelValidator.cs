using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrFenceDoorUpdateModel"/> .
    /// </summary>
    public partial class TTrFenceDoorUpdateModelValidator
        : AbstractValidator<TTrFenceDoorUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrFenceDoorUpdateModelValidator"/> class.
        /// </summary>
        public TTrFenceDoorUpdateModelValidator()
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
