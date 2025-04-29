using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TRcCameraIdsCreateModel"/> .
    /// </summary>
    public partial class TRcCameraIdsCreateModelValidator
        : AbstractValidator<TRcCameraIdsCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcCameraIdsCreateModelValidator"/> class.
        /// </summary>
        public TRcCameraIdsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CameraCode).MaximumLength(30);
            RuleFor(p => p.CameraName).MaximumLength(30);
            RuleFor(p => p.AlarmChannelName).MaximumLength(10);
            RuleFor(p => p.AlarmTime).MaximumLength(30);
            RuleFor(p => p.AlarmPicture).MaximumLength(500);
            RuleFor(p => p.BayId).MaximumLength(32);
            RuleFor(p => p.BayName).MaximumLength(32);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
