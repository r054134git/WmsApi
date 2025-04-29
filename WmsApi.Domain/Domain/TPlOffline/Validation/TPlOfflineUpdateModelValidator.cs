using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlOfflineUpdateModel"/> .
    /// </summary>
    public partial class TPlOfflineUpdateModelValidator
        : AbstractValidator<TPlOfflineUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlOfflineUpdateModelValidator"/> class.
        /// </summary>
        public TPlOfflineUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
