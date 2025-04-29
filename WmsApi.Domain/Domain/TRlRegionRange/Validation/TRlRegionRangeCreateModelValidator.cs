using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlRegionRangeCreateModel"/> .
    /// </summary>
    public partial class TRlRegionRangeCreateModelValidator
        : AbstractValidator<TRlRegionRangeCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlRegionRangeCreateModelValidator"/> class.
        /// </summary>
        public TRlRegionRangeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Region).MaximumLength(32);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
