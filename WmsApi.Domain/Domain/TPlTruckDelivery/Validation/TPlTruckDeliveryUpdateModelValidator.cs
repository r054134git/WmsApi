using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="TPlTruckDeliveryUpdateModel"/> .
    /// </summary>
    public partial class TPlTruckDeliveryUpdateModelValidator
        : AbstractValidator<TPlTruckDeliveryUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckDeliveryUpdateModelValidator"/> class.
        /// </summary>
        public TPlTruckDeliveryUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OperationMark).MaximumLength(1);
            RuleFor(p => p.DeliveryOrderNo).MaximumLength(13);
            RuleFor(p => p.IsWeighting).MaximumLength(1);
            RuleFor(p => p.CustomerNo).MaximumLength(30);
            RuleFor(p => p.ChineseCustomer).MaximumLength(50);
            RuleFor(p => p.DeliveryType).MaximumLength(1);
            RuleFor(p => p.SalesType).MaximumLength(1);
            RuleFor(p => p.ProductType).MaximumLength(5);
            RuleFor(p => p.ProductTypeChinese).MaximumLength(30);
            RuleFor(p => p.FreightBear).MaximumLength(1);
            RuleFor(p => p.TransportType).MaximumLength(1);
            RuleFor(p => p.SourceHouse).MaximumLength(10);
            RuleFor(p => p.DestHouse).MaximumLength(10);
            RuleFor(p => p.SourceCode).MaximumLength(10);
            RuleFor(p => p.DestCode).MaximumLength(10);
            RuleFor(p => p.SourcePortCode).MaximumLength(4);
            RuleFor(p => p.DestPortCode).MaximumLength(4);
            RuleFor(p => p.PrivateLineCode).MaximumLength(10);
            RuleFor(p => p.IsBillingTwo).MaximumLength(1);
            RuleFor(p => p.PortBatchNo).MaximumLength(15);
            RuleFor(p => p.CarrierCompanyA).MaximumLength(30);
            RuleFor(p => p.CarrierCompanyB).MaximumLength(30);
            RuleFor(p => p.Note).MaximumLength(200);
            RuleFor(p => p.ContractNo).MaximumLength(20);
            RuleFor(p => p.ContractItemNo).MaximumLength(5);
            RuleFor(p => p.OrderNo).MaximumLength(20);
            RuleFor(p => p.DetailNo).MaximumLength(15);
            RuleFor(p => p.SteelGradeNo).MaximumLength(15);
            RuleFor(p => p.Grade).MaximumLength(2);
            RuleFor(p => p.TypeCode).MaximumLength(20);
            RuleFor(p => p.SizeMessage).MaximumLength(1);
            RuleFor(p => p.SizeMessageChinese).MaximumLength(50);
            RuleFor(p => p.IsSpecifyCoilNo).MaximumLength(1);
            RuleFor(p => p.IsLast).MaximumLength(1);
            RuleFor(p => p.OldPortBatchNo).MaximumLength(15);
            RuleFor(p => p.Specification).MaximumLength(50);
            RuleFor(p => p.CarType).MaximumLength(4);
            RuleFor(p => p.VirtualShipment).MaximumLength(1);
            RuleFor(p => p.Psrno).MaximumLength(25);
            RuleFor(p => p.MarbiaStandardCode).MaximumLength(20);
            RuleFor(p => p.PackageType).MaximumLength(5);
            RuleFor(p => p.SpecialRequest1).MaximumLength(20);
            RuleFor(p => p.SpecialRequest2).MaximumLength(200);
            RuleFor(p => p.SpecialRequest3).MaximumLength(20);
            RuleFor(p => p.SpecialRequest4).MaximumLength(20);
            RuleFor(p => p.SpecialRequest5).MaximumLength(20);
            RuleFor(p => p.SpecialRequest6).MaximumLength(20);
            RuleFor(p => p.SpecialRequest7).MaximumLength(20);
            RuleFor(p => p.SpecialRequest8).MaximumLength(20);
            RuleFor(p => p.SpecialRequest9).MaximumLength(20);
            RuleFor(p => p.SpecialRequest10).MaximumLength(20);
            RuleFor(p => p.SpecialRequest11).MaximumLength(20);
            RuleFor(p => p.SpecialRequest12).MaximumLength(20);
            RuleFor(p => p.SpecialRequest13).MaximumLength(20);
            RuleFor(p => p.SpecialRequest14).MaximumLength(20);
            RuleFor(p => p.SpecialRequest15).MaximumLength(20);
            RuleFor(p => p.UseCode).MaximumLength(5);
            RuleFor(p => p.Remark).MaximumLength(255);
            #endregion
        }

    }
}
