using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhDestHouseUpdateModel"/> .
    /// </summary>
    public partial class TWhDestHouseUpdateModelValidator
        : AbstractValidator<TWhDestHouseUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhDestHouseUpdateModelValidator"/> class.
        /// </summary>
        public TWhDestHouseUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.DestHouse).MaximumLength(10);
            RuleFor(p => p.DestCode).MaximumLength(10);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
