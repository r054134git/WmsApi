using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TUmColSetCreateModel"/> .
    /// </summary>
    public partial class TUmColSetCreateModelValidator
        : AbstractValidator<TUmColSetCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmColSetCreateModelValidator"/> class.
        /// </summary>
        public TUmColSetCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TableName).NotEmpty();
            RuleFor(p => p.TableName).MaximumLength(32);
            RuleFor(p => p.Type).NotEmpty();
            RuleFor(p => p.Type).MaximumLength(32);
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(32);
            RuleFor(p => p.DataIndex).NotEmpty();
            RuleFor(p => p.DataIndex).MaximumLength(32);
            RuleFor(p => p.Filters).MaximumLength(32);
            RuleFor(p => p.Selects).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
