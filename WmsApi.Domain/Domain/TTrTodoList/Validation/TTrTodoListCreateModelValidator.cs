using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TTrTodoListCreateModel"/> .
    /// </summary>
    public partial class TTrTodoListCreateModelValidator
        : AbstractValidator<TTrTodoListCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTodoListCreateModelValidator"/> class.
        /// </summary>
        public TTrTodoListCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BayName).MaximumLength(255);
            RuleFor(p => p.Description).MaximumLength(2000);
            RuleFor(p => p.Sender).MaximumLength(255);
            #endregion
        }

    }
}
