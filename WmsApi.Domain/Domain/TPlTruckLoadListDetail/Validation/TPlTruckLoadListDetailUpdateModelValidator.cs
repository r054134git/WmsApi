using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckLoadListDetailUpdateModel"/> .
    /// </summary>
    public partial class TPlTruckLoadListDetailUpdateModelValidator
        : AbstractValidator<TPlTruckLoadListDetailUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckLoadListDetailUpdateModelValidator"/> class.
        /// </summary>
        public TPlTruckLoadListDetailUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TruckLoadingNo).MaximumLength(20);
            RuleFor(p => p.CoilNo).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
