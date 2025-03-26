using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcWorkModeCreateModel"/> .
    /// </summary>
    public partial class TRcWorkModeCreateModelValidator
        : AbstractValidator<TRcWorkModeCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcWorkModeCreateModelValidator"/> class.
        /// </summary>
        public TRcWorkModeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CraneName).NotEmpty();
            RuleFor(p => p.CraneName).MaximumLength(30);
            #endregion
        }

    }
}
