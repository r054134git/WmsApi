using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TScClientUpdateModel"/> .
    /// </summary>
    public partial class TScClientUpdateModelValidator
        : AbstractValidator<TScClientUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScClientUpdateModelValidator"/> class.
        /// </summary>
        public TScClientUpdateModelValidator()
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
