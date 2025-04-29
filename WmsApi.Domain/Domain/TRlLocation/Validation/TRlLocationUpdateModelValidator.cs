using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlLocationUpdateModel"/> .
    /// </summary>
    public partial class TRlLocationUpdateModelValidator
        : AbstractValidator<TRlLocationUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlLocationUpdateModelValidator"/> class.
        /// </summary>
        public TRlLocationUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
