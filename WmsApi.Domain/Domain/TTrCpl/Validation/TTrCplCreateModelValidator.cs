using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrCplCreateModel"/> .
    /// </summary>
    public partial class TTrCplCreateModelValidator
        : AbstractValidator<TTrCplCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCplCreateModelValidator"/> class.
        /// </summary>
        public TTrCplCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
