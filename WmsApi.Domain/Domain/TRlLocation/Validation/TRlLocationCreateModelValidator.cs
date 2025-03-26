using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlLocationCreateModel"/> .
    /// </summary>
    public partial class TRlLocationCreateModelValidator
        : AbstractValidator<TRlLocationCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlLocationCreateModelValidator"/> class.
        /// </summary>
        public TRlLocationCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
