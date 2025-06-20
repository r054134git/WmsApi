using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrCplUpdateModel"/> .
    /// </summary>
    public partial class TTrCplUpdateModelValidator
        : AbstractValidator<TTrCplUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCplUpdateModelValidator"/> class.
        /// </summary>
        public TTrCplUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
