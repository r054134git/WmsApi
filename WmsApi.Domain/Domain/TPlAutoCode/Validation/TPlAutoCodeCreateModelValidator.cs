using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlAutoCodeCreateModel"/> .
    /// </summary>
    public partial class TPlAutoCodeCreateModelValidator
        : AbstractValidator<TPlAutoCodeCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlAutoCodeCreateModelValidator"/> class.
        /// </summary>
        public TPlAutoCodeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CodeType).NotEmpty();
            RuleFor(p => p.CodeType).MaximumLength(20);
            RuleFor(p => p.Owner).NotEmpty();
            RuleFor(p => p.Owner).MaximumLength(10);
            RuleFor(p => p.InitNum).MaximumLength(50);
            RuleFor(p => p.InitCycle).NotEmpty();
            RuleFor(p => p.InitCycle).MaximumLength(1);
            RuleFor(p => p.CurSernum).NotEmpty();
            RuleFor(p => p.CurSernum).MaximumLength(50);
            RuleFor(p => p.ZeroFlg).NotEmpty();
            RuleFor(p => p.ZeroFlg).MaximumLength(2);
            RuleFor(p => p.SequenceStyle).MaximumLength(50);
            RuleFor(p => p.Memo).MaximumLength(60);
            #endregion
        }

    }
}
