using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckLoadListDetailCreateModel"/> .
    /// </summary>
    public partial class TPlTruckLoadListDetailCreateModelValidator
        : AbstractValidator<TPlTruckLoadListDetailCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckLoadListDetailCreateModelValidator"/> class.
        /// </summary>
        public TPlTruckLoadListDetailCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TruckLoadingNo).MaximumLength(20);
            RuleFor(p => p.CoilNo).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
