using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlTransferPrewiredUpdateModel"/> .
    /// </summary>
    public partial class TRlTransferPrewiredUpdateModelValidator
        : AbstractValidator<TRlTransferPrewiredUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlTransferPrewiredUpdateModelValidator"/> class.
        /// </summary>
        public TRlTransferPrewiredUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
