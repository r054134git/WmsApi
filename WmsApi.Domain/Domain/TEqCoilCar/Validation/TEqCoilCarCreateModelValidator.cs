using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqCoilCarCreateModel"/> .
    /// </summary>
    public partial class TEqCoilCarCreateModelValidator
        : AbstractValidator<TEqCoilCarCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCoilCarCreateModelValidator"/> class.
        /// </summary>
        public TEqCoilCarCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
