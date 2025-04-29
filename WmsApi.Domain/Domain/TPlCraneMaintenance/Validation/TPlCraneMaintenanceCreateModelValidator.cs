using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlCraneMaintenanceCreateModel"/> .
    /// </summary>
    public partial class TPlCraneMaintenanceCreateModelValidator
        : AbstractValidator<TPlCraneMaintenanceCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlCraneMaintenanceCreateModelValidator"/> class.
        /// </summary>
        public TPlCraneMaintenanceCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayId).NotEmpty();
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.BayName).MaximumLength(30);
            RuleFor(p => p.CraneId).MaximumLength(32);
            RuleFor(p => p.CraneName).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
