using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqFenceAreaCreateModel"/> .
    /// </summary>
    public partial class TEqFenceAreaCreateModelValidator
        : AbstractValidator<TEqFenceAreaCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqFenceAreaCreateModelValidator"/> class.
        /// </summary>
        public TEqFenceAreaCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
