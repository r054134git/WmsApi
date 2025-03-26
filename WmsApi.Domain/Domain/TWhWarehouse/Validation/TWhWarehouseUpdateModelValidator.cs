using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhWarehouseUpdateModel"/> .
    /// </summary>
    public partial class TWhWarehouseUpdateModelValidator
        : AbstractValidator<TWhWarehouseUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhWarehouseUpdateModelValidator"/> class.
        /// </summary>
        public TWhWarehouseUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(100);
            RuleFor(p => p.Company).NotEmpty();
            RuleFor(p => p.Company).MaximumLength(100);
            RuleFor(p => p.Workshop).NotEmpty();
            RuleFor(p => p.Workshop).MaximumLength(100);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
