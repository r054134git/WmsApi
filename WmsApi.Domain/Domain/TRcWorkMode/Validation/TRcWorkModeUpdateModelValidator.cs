using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcWorkModeUpdateModel"/> .
    /// </summary>
    public partial class TRcWorkModeUpdateModelValidator
        : AbstractValidator<TRcWorkModeUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcWorkModeUpdateModelValidator"/> class.
        /// </summary>
        public TRcWorkModeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CraneName).NotEmpty();
            RuleFor(p => p.CraneName).MaximumLength(30);
            #endregion
        }

    }
}
