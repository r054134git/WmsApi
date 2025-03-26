using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlBackReturnCreateModel"/> .
    /// </summary>
    public partial class TPlBackReturnCreateModelValidator
        : AbstractValidator<TPlBackReturnCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBackReturnCreateModelValidator"/> class.
        /// </summary>
        public TPlBackReturnCreateModelValidator()
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
