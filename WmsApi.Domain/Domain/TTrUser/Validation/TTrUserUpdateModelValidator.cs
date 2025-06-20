using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrUserUpdateModel"/> .
    /// </summary>
    public partial class TTrUserUpdateModelValidator
        : AbstractValidator<TTrUserUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrUserUpdateModelValidator"/> class.
        /// </summary>
        public TTrUserUpdateModelValidator()
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
