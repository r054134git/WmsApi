using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhTrainLocationCreateModel"/> .
    /// </summary>
    public partial class TWhTrainLocationCreateModelValidator
        : AbstractValidator<TWhTrainLocationCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTrainLocationCreateModelValidator"/> class.
        /// </summary>
        public TWhTrainLocationCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LocationId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
