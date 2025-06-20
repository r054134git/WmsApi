using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmShiftCreateModel"/> .
    /// </summary>
    public partial class TUmShiftCreateModelValidator
        : AbstractValidator<TUmShiftCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmShiftCreateModelValidator"/> class.
        /// </summary>
        public TUmShiftCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
