using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TagcopylistCreateModel"/> .
    /// </summary>
    public partial class TagcopylistCreateModelValidator
        : AbstractValidator<TagcopylistCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagcopylistCreateModelValidator"/> class.
        /// </summary>
        public TagcopylistCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CoilNo).NotEmpty();
            RuleFor(p => p.CoilNo).MaximumLength(30);
            RuleFor(p => p.ProdCName).MaximumLength(200);
            RuleFor(p => p.SgStd).MaximumLength(100);
            RuleFor(p => p.Edge).NotEmpty();
            RuleFor(p => p.Edge).MaximumLength(100);
            RuleFor(p => p.CodeDesc1Content).MaximumLength(64);
            RuleFor(p => p.ProdTime).NotEmpty();
            RuleFor(p => p.ProdTime).MaximumLength(64);
            #endregion
        }

    }
}
