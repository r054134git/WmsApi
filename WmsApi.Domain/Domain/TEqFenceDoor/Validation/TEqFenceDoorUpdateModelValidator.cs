using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqFenceDoorUpdateModel"/> .
    /// </summary>
    public partial class TEqFenceDoorUpdateModelValidator
        : AbstractValidator<TEqFenceDoorUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqFenceDoorUpdateModelValidator"/> class.
        /// </summary>
        public TEqFenceDoorUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(255);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
