using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrTodoListUpdateModel"/> .
    /// </summary>
    public partial class TTrTodoListUpdateModelValidator
        : AbstractValidator<TTrTodoListUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTodoListUpdateModelValidator"/> class.
        /// </summary>
        public TTrTodoListUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayName).MaximumLength(255);
            RuleFor(p => p.Description).MaximumLength(2000);
            RuleFor(p => p.Sender).MaximumLength(255);
            #endregion
        }

    }
}
