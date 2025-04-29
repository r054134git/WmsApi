using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqTrainCarUpdateModel"/> .
    /// </summary>
    public partial class TEqTrainCarUpdateModelValidator
        : AbstractValidator<TEqTrainCarUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqTrainCarUpdateModelValidator"/> class.
        /// </summary>
        public TEqTrainCarUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
