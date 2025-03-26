using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhErrorCreateModel"/> .
    /// </summary>
    public partial class TWhErrorCreateModelValidator
        : AbstractValidator<TWhErrorCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhErrorCreateModelValidator"/> class.
        /// </summary>
        public TWhErrorCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ErrorMessage).NotEmpty();
            RuleFor(p => p.ErrorMessage).MaximumLength(200);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
