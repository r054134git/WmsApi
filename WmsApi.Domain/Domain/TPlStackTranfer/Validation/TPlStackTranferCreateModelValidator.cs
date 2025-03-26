using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlStackTranferCreateModel"/> .
    /// </summary>
    public partial class TPlStackTranferCreateModelValidator
        : AbstractValidator<TPlStackTranferCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlStackTranferCreateModelValidator"/> class.
        /// </summary>
        public TPlStackTranferCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayId).NotEmpty();
            RuleFor(p => p.BayId).MaximumLength(30);
            RuleFor(p => p.AreaId).MaximumLength(32);
            RuleFor(p => p.StartStackId).MaximumLength(32);
            RuleFor(p => p.EndStackId).MaximumLength(32);
            RuleFor(p => p.StartColId).MaximumLength(32);
            RuleFor(p => p.EndColId).MaximumLength(32);
            RuleFor(p => p.MaterialNoList).MaximumLength(4000);
            RuleFor(p => p.MaterialNoListAll).MaximumLength(4000);
            RuleFor(p => p.Remark).MaximumLength(4000);
            #endregion
        }

    }
}
