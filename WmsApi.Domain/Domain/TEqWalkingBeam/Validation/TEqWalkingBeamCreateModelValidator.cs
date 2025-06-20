using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqWalkingBeamCreateModel"/> .
    /// </summary>
    public partial class TEqWalkingBeamCreateModelValidator
        : AbstractValidator<TEqWalkingBeamCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqWalkingBeamCreateModelValidator"/> class.
        /// </summary>
        public TEqWalkingBeamCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OwnerId).NotEmpty();
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.MoveForwardAddress).MaximumLength(255);
            RuleFor(p => p.MoveBackwardAddress).MaximumLength(255);
            RuleFor(p => p.GoUpAddress).MaximumLength(255);
            RuleFor(p => p.GoDownAddress).MaximumLength(255);
            RuleFor(p => p.LockStatusAddress).MaximumLength(255);
            RuleFor(p => p.LockCmdAddress).MaximumLength(255);
            #endregion
        }

    }
}
