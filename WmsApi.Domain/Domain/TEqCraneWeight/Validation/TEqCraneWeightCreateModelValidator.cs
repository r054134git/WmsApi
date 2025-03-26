using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqCraneWeightCreateModel"/> .
    /// </summary>
    public partial class TEqCraneWeightCreateModelValidator
        : AbstractValidator<TEqCraneWeightCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCraneWeightCreateModelValidator"/> class.
        /// </summary>
        public TEqCraneWeightCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CraneId).NotEmpty();
            RuleFor(p => p.CraneId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
