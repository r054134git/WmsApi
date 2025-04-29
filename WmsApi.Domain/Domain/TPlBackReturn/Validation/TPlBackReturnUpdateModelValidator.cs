using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlBackReturnUpdateModel"/> .
    /// </summary>
    public partial class TPlBackReturnUpdateModelValidator
        : AbstractValidator<TPlBackReturnUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBackReturnUpdateModelValidator"/> class.
        /// </summary>
        public TPlBackReturnUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayCode).MaximumLength(30);
            RuleFor(p => p.MaterialNo).NotEmpty();
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.RetReason).MaximumLength(200);
            RuleFor(p => p.RetType).MaximumLength(5);
            RuleFor(p => p.RetSource).MaximumLength(5);
            RuleFor(p => p.RetLocation).MaximumLength(30);
            RuleFor(p => p.BackLocation).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
