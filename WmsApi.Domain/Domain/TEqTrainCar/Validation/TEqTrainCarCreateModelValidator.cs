using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqTrainCarCreateModel"/> .
    /// </summary>
    public partial class TEqTrainCarCreateModelValidator
        : AbstractValidator<TEqTrainCarCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqTrainCarCreateModelValidator"/> class.
        /// </summary>
        public TEqTrainCarCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
