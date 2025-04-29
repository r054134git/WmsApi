using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqCoilCarUpdateModel"/> .
    /// </summary>
    public partial class TEqCoilCarUpdateModelValidator
        : AbstractValidator<TEqCoilCarUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCoilCarUpdateModelValidator"/> class.
        /// </summary>
        public TEqCoilCarUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
