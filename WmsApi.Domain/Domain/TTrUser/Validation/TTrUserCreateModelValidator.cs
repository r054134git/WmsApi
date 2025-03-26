using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrUserCreateModel"/> .
    /// </summary>
    public partial class TTrUserCreateModelValidator
        : AbstractValidator<TTrUserCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrUserCreateModelValidator"/> class.
        /// </summary>
        public TTrUserCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ClientName).MaximumLength(255);
            RuleFor(p => p.LoginUserId).MaximumLength(32);
            RuleFor(p => p.TeamId).MaximumLength(32);
            RuleFor(p => p.ShiftId).MaximumLength(32);
            #endregion
        }

    }
}
