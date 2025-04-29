using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRlTransferPrewiredCreateModel"/> .
    /// </summary>
    public partial class TRlTransferPrewiredCreateModelValidator
        : AbstractValidator<TRlTransferPrewiredCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlTransferPrewiredCreateModelValidator"/> class.
        /// </summary>
        public TRlTransferPrewiredCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
