using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhErrorUpdateModel"/> .
    /// </summary>
    public partial class TWhErrorUpdateModelValidator
        : AbstractValidator<TWhErrorUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhErrorUpdateModelValidator"/> class.
        /// </summary>
        public TWhErrorUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ErrorMessage).NotEmpty();
            RuleFor(p => p.ErrorMessage).MaximumLength(200);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
