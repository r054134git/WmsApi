using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlLocationAssignUpdateModel"/> .
    /// </summary>
    public partial class TRlLocationAssignUpdateModelValidator
        : AbstractValidator<TRlLocationAssignUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlLocationAssignUpdateModelValidator"/> class.
        /// </summary>
        public TRlLocationAssignUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayCode).MaximumLength(5);
            RuleFor(p => p.RuleCode).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
