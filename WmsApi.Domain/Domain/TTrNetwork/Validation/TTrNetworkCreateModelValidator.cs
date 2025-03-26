using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrNetworkCreateModel"/> .
    /// </summary>
    public partial class TTrNetworkCreateModelValidator
        : AbstractValidator<TTrNetworkCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrNetworkCreateModelValidator"/> class.
        /// </summary>
        public TTrNetworkCreateModelValidator()
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
