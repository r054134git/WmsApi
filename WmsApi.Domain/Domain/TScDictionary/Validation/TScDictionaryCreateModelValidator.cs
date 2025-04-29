using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TScDictionaryCreateModel"/> .
    /// </summary>
    public partial class TScDictionaryCreateModelValidator
        : AbstractValidator<TScDictionaryCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScDictionaryCreateModelValidator"/> class.
        /// </summary>
        public TScDictionaryCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Key).NotEmpty();
            RuleFor(p => p.Key).MaximumLength(255);
            RuleFor(p => p.Value).NotEmpty();
            RuleFor(p => p.Value).MaximumLength(255);
            RuleFor(p => p.Owner).MaximumLength(32);
            #endregion
        }

    }
}
