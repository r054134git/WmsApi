using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqTrainCreateModel"/> .
    /// </summary>
    public partial class TEqTrainCreateModelValidator
        : AbstractValidator<TEqTrainCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqTrainCreateModelValidator"/> class.
        /// </summary>
        public TEqTrainCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(10);
            RuleFor(p => p.Car1Id).MaximumLength(32);
            RuleFor(p => p.Car2Id).MaximumLength(32);
            RuleFor(p => p.Car3Id).MaximumLength(32);
            RuleFor(p => p.Car4Id).MaximumLength(32);
            RuleFor(p => p.Car5Id).MaximumLength(32);
            RuleFor(p => p.Car6Id).MaximumLength(32);
            RuleFor(p => p.Car7Id).MaximumLength(32);
            RuleFor(p => p.Car8Id).MaximumLength(32);
            RuleFor(p => p.Car9Id).MaximumLength(32);
            RuleFor(p => p.Car10Id).MaximumLength(32);
            RuleFor(p => p.Car11Id).MaximumLength(32);
            RuleFor(p => p.Car12Id).MaximumLength(32);
            RuleFor(p => p.Car13Id).MaximumLength(32);
            RuleFor(p => p.Car14Id).MaximumLength(32);
            RuleFor(p => p.Car15Id).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
