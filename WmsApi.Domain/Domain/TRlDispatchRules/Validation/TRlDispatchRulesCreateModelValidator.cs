using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlDispatchRulesCreateModel"/> .
    /// </summary>
    public partial class TRlDispatchRulesCreateModelValidator
        : AbstractValidator<TRlDispatchRulesCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlDispatchRulesCreateModelValidator"/> class.
        /// </summary>
        public TRlDispatchRulesCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NextProcess).NotEmpty();
            RuleFor(p => p.NextProcess).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
