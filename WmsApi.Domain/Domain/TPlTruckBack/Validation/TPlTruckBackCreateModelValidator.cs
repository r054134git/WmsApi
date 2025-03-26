using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckBackCreateModel"/> .
    /// </summary>
    public partial class TPlTruckBackCreateModelValidator
        : AbstractValidator<TPlTruckBackCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckBackCreateModelValidator"/> class.
        /// </summary>
        public TPlTruckBackCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TruckBackNo).NotEmpty();
            RuleFor(p => p.TruckBackNo).MaximumLength(30);
            RuleFor(p => p.MaterialNo).MaximumLength(300);
            RuleFor(p => p.TruckNo).MaximumLength(11);
            RuleFor(p => p.SuggestBay).MaximumLength(5);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
