using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhTrainLocationUpdateModel"/> .
    /// </summary>
    public partial class TWhTrainLocationUpdateModelValidator
        : AbstractValidator<TWhTrainLocationUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTrainLocationUpdateModelValidator"/> class.
        /// </summary>
        public TWhTrainLocationUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LocationId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
