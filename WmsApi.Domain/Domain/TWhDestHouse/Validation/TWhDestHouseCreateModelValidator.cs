using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TWhDestHouseCreateModel"/> .
    /// </summary>
    public partial class TWhDestHouseCreateModelValidator
        : AbstractValidator<TWhDestHouseCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhDestHouseCreateModelValidator"/> class.
        /// </summary>
        public TWhDestHouseCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.DestHouse).MaximumLength(10);
            RuleFor(p => p.DestCode).MaximumLength(10);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
