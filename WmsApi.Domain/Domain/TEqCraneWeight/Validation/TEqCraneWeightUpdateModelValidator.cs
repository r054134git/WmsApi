using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqCraneWeightUpdateModel"/> .
    /// </summary>
    public partial class TEqCraneWeightUpdateModelValidator
        : AbstractValidator<TEqCraneWeightUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCraneWeightUpdateModelValidator"/> class.
        /// </summary>
        public TEqCraneWeightUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CraneId).NotEmpty();
            RuleFor(p => p.CraneId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
