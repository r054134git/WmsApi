using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqGateParkingUpdateModel"/> .
    /// </summary>
    public partial class TEqGateParkingUpdateModelValidator
        : AbstractValidator<TEqGateParkingUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqGateParkingUpdateModelValidator"/> class.
        /// </summary>
        public TEqGateParkingUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Code).MaximumLength(255);
            RuleFor(p => p.GateId).MaximumLength(255);
            RuleFor(p => p.IpEntry).MaximumLength(255);
            RuleFor(p => p.IpLed).MaximumLength(255);
            RuleFor(p => p.OwnerId).MaximumLength(32);
            RuleFor(p => p.BayCode).MaximumLength(5);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
