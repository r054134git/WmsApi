using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrNetworkUpdateModel"/> .
    /// </summary>
    public partial class TTrNetworkUpdateModelValidator
        : AbstractValidator<TTrNetworkUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrNetworkUpdateModelValidator"/> class.
        /// </summary>
        public TTrNetworkUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(30);
            RuleFor(p => p.IpAddress).MaximumLength(30);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
