using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlRegionRangeUpdateModel"/> .
    /// </summary>
    public partial class TRlRegionRangeUpdateModelValidator
        : AbstractValidator<TRlRegionRangeUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlRegionRangeUpdateModelValidator"/> class.
        /// </summary>
        public TRlRegionRangeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Region).MaximumLength(32);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
