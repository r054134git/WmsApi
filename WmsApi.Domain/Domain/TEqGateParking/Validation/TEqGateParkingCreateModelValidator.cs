using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TEqGateParkingCreateModel"/> .
    /// </summary>
    public partial class TEqGateParkingCreateModelValidator
        : AbstractValidator<TEqGateParkingCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqGateParkingCreateModelValidator"/> class.
        /// </summary>
        public TEqGateParkingCreateModelValidator()
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
