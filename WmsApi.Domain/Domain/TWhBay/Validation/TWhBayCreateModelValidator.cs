using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhBayCreateModel"/> .
    /// </summary>
    public partial class TWhBayCreateModelValidator
        : AbstractValidator<TWhBayCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhBayCreateModelValidator"/> class.
        /// </summary>
        public TWhBayCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(50);
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(30);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.LocationCode).MaximumLength(10);
            RuleFor(p => p.LocationNameFormat).MaximumLength(255);
            RuleFor(p => p.ServerIp).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
