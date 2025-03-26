using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlDispatchRulesUpdateModel"/> .
    /// </summary>
    public partial class TRlDispatchRulesUpdateModelValidator
        : AbstractValidator<TRlDispatchRulesUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlDispatchRulesUpdateModelValidator"/> class.
        /// </summary>
        public TRlDispatchRulesUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NextProcess).NotEmpty();
            RuleFor(p => p.NextProcess).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
