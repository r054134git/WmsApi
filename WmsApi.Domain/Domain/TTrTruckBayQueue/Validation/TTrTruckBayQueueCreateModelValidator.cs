using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrTruckBayQueueCreateModel"/> .
    /// </summary>
    public partial class TTrTruckBayQueueCreateModelValidator
        : AbstractValidator<TTrTruckBayQueueCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTruckBayQueueCreateModelValidator"/> class.
        /// </summary>
        public TTrTruckBayQueueCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TruckNo).MaximumLength(30);
            RuleFor(p => p.MainLoadingNo).MaximumLength(32);
            RuleFor(p => p.BayCode).MaximumLength(5);
            RuleFor(p => p.HouseNo).MaximumLength(5);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
