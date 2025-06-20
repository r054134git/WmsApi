using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhAreaUpdateModel"/> .
    /// </summary>
    public partial class TWhAreaUpdateModelValidator
        : AbstractValidator<TWhAreaUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhAreaUpdateModelValidator"/> class.
        /// </summary>
        public TWhAreaUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(30);
            RuleFor(p => p.OwnerBussinessName).NotEmpty();
            RuleFor(p => p.OwnerBussinessName).MaximumLength(32);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
