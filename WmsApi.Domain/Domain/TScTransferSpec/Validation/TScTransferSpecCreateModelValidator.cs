using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TScTransferSpecCreateModel"/> .
    /// </summary>
    public partial class TScTransferSpecCreateModelValidator
        : AbstractValidator<TScTransferSpecCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScTransferSpecCreateModelValidator"/> class.
        /// </summary>
        public TScTransferSpecCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
