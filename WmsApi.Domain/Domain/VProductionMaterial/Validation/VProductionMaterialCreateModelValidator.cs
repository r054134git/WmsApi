using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="VProductionMaterialCreateModel"/> .
    /// </summary>
    public partial class VProductionMaterialCreateModelValidator
        : AbstractValidator<VProductionMaterialCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VProductionMaterialCreateModelValidator"/> class.
        /// </summary>
        public VProductionMaterialCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.No).NotEmpty();
            RuleFor(p => p.No).MaximumLength(30);
            RuleFor(p => p.ProductionNo).MaximumLength(32);
            RuleFor(p => p.MaterialId).MaximumLength(32);
            RuleFor(p => p.MaterialNo).NotEmpty();
            RuleFor(p => p.MaterialNo).MaximumLength(30);
            RuleFor(p => p.Remark).MaximumLength(255);
            RuleFor(p => p.PortLotNumber).MaximumLength(200);
            RuleFor(p => p.MatDirection).MaximumLength(5);
            #endregion
        }

    }
}
