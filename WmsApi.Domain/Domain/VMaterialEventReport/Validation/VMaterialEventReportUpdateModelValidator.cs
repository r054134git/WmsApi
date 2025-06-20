using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="VMaterialEventReportUpdateModel"/> .
    /// </summary>
    public partial class VMaterialEventReportUpdateModelValidator
        : AbstractValidator<VMaterialEventReportUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMaterialEventReportUpdateModelValidator"/> class.
        /// </summary>
        public VMaterialEventReportUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayCode).MaximumLength(5);
            RuleFor(p => p.CraneName).MaximumLength(20);
            RuleFor(p => p.MaterialId).NotEmpty();
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.MaterialNoOld).MaximumLength(30);
            RuleFor(p => p.OperationType).NotEmpty();
            RuleFor(p => p.OperationType).MaximumLength(32);
            RuleFor(p => p.ContentType).NotEmpty();
            RuleFor(p => p.ContentType).MaximumLength(32);
            RuleFor(p => p.FromLocationName).MaximumLength(255);
            RuleFor(p => p.ToLocationName).MaximumLength(255);
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.FromPosition).MaximumLength(255);
            RuleFor(p => p.ToPosition).MaximumLength(255);
            RuleFor(p => p.Result).NotEmpty();
            RuleFor(p => p.Result).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            RuleFor(p => p.MatDirection).MaximumLength(5);
            RuleFor(p => p.CustomerName).MaximumLength(100);
            #endregion
        }

    }
}
