using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlOfflineCreateModel"/> .
    /// </summary>
    public partial class TPlOfflineCreateModelValidator
        : AbstractValidator<TPlOfflineCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlOfflineCreateModelValidator"/> class.
        /// </summary>
        public TPlOfflineCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
