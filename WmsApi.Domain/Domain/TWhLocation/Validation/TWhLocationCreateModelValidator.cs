using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhLocationCreateModel"/> .
    /// </summary>
    public partial class TWhLocationCreateModelValidator
        : AbstractValidator<TWhLocationCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhLocationCreateModelValidator"/> class.
        /// </summary>
        public TWhLocationCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.BayCode).NotEmpty();
            RuleFor(p => p.BayCode).MaximumLength(30);
            RuleFor(p => p.AreaCode).NotEmpty();
            RuleFor(p => p.AreaCode).MaximumLength(30);
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.AreaId).NotEmpty();
            RuleFor(p => p.AreaId).MaximumLength(32);
            RuleFor(p => p.BayId).NotEmpty();
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.OwnerBussinessName).NotEmpty();
            RuleFor(p => p.OwnerBussinessName).MaximumLength(32);
            RuleFor(p => p.AreaCodeC3).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
