using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TScClientCreateModel"/> .
    /// </summary>
    public partial class TScClientCreateModelValidator
        : AbstractValidator<TScClientCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScClientCreateModelValidator"/> class.
        /// </summary>
        public TScClientCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Code).MaximumLength(255);
            RuleFor(p => p.IpAddress).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
