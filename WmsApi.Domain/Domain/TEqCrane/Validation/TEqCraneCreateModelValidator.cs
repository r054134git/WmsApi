using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqCraneCreateModel"/> .
    /// </summary>
    public partial class TEqCraneCreateModelValidator
        : AbstractValidator<TEqCraneCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCraneCreateModelValidator"/> class.
        /// </summary>
        public TEqCraneCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(20);
            RuleFor(p => p.No).NotEmpty();
            RuleFor(p => p.No).MaximumLength(10);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
