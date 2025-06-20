using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TScTransferSpecUpdateModel"/> .
    /// </summary>
    public partial class TScTransferSpecUpdateModelValidator
        : AbstractValidator<TScTransferSpecUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScTransferSpecUpdateModelValidator"/> class.
        /// </summary>
        public TScTransferSpecUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
