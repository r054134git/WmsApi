using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlTruckDelivery" />
	/// </summary>
	public partial class TPlTruckDeliveryMap
        : IEntityTypeConfiguration<Entities.TPlTruckDelivery>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlTruckDelivery" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlTruckDelivery> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_truck_delivery");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.OperationMark)
                .HasColumnName("OPERATION_MARK")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.DeliveryOrderNo)
                .HasColumnName("DELIVERY_ORDER_NO")
                .HasColumnType("varchar(13)")
                .HasMaxLength(13);

            builder.Property(t => t.ItemCount)
                .HasColumnName("ITEM_COUNT")
                .HasColumnType("decimal(13,0)");

            builder.Property(t => t.WeightTotal)
                .HasColumnName("WEIGHT_TOTAL")
                .HasColumnType("decimal(13,0)");

            builder.Property(t => t.IsWeighting)
                .HasColumnName("IS_WEIGHTING")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.CustomerNo)
                .HasColumnName("CUSTOMER_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ChineseCustomer)
                .HasColumnName("CHINESE_CUSTOMER")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DeliveryType)
                .HasColumnName("DELIVERY_TYPE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.SalesType)
                .HasColumnName("SALES_TYPE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.ProductType)
                .HasColumnName("PRODUCT_TYPE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.ProductTypeChinese)
                .HasColumnName("PRODUCT_TYPE_CHINESE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.FreightBear)
                .HasColumnName("FREIGHT_BEAR")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.TransportType)
                .HasColumnName("TRANSPORT_TYPE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.SourceHouse)
                .HasColumnName("SOURCE_HOUSE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.DestHouse)
                .HasColumnName("DEST_HOUSE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.DestCode)
                .HasColumnName("DEST_CODE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.SourcePortCode)
                .HasColumnName("SOURCE_PORT_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.DestPortCode)
                .HasColumnName("DEST_PORT_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.PrivateLineCode)
                .HasColumnName("PRIVATE_LINE_CODE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.IsBillingTwo)
                .HasColumnName("IS_BILLING_TWO")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PortBatchNo)
                .HasColumnName("PORT_BATCH_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.CarrierCompanyA)
                .HasColumnName("CARRIER_COMPANY_A")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.CarrierCompanyB)
                .HasColumnName("CARRIER_COMPANY_B")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Note)
                .HasColumnName("NOTE")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.ContractNo)
                .HasColumnName("CONTRACT_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ContractItemNo)
                .HasColumnName("CONTRACT_ITEM_NO")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.OrderNo)
                .HasColumnName("ORDER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DetailNo)
                .HasColumnName("DETAIL_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.SteelGradeNo)
                .HasColumnName("STEEL_GRADE_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.Thickness)
                .HasColumnName("THICKNESS")
                .HasColumnType("decimal(6,0)");

            builder.Property(t => t.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("decimal(5,0)");

            builder.Property(t => t.Length)
                .HasColumnName("LENGTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.Grade)
                .HasColumnName("GRADE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.TypeCode)
                .HasColumnName("TYPE_CODE")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SizeMessage)
                .HasColumnName("SIZE_MESSAGE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.SizeMessageChinese)
                .HasColumnName("SIZE_MESSAGE_CHINESE")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PlanNo)
                .HasColumnName("PLAN_NO")
                .HasColumnType("decimal(20,0)");

            builder.Property(t => t.PlanWeight)
                .HasColumnName("PLAN_WEIGHT")
                .HasColumnType("decimal(20,0)");

            builder.Property(t => t.IsSpecifyCoilNo)
                .HasColumnName("IS_SPECIFY_COIL_NO")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.IsLast)
                .HasColumnName("IS_LAST")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.OldPortBatchNo)
                .HasColumnName("OLD_PORT_BATCH_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.Specification)
                .HasColumnName("SPECIFICATION")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CarType)
                .HasColumnName("CAR_TYPE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.VirtualShipment)
                .HasColumnName("VIRTUAL_SHIPMENT")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PieceWeightUpperLimit)
                .HasColumnName("PIECE_WEIGHT_UPPER_LIMIT")
                .HasColumnType("decimal(20,0)");

            builder.Property(t => t.PieceWeightFloorLimit)
                .HasColumnName("PIECE_WEIGHT_FLOOR_LIMIT")
                .HasColumnType("decimal(20,0)");

            builder.Property(t => t.Psrno)
                .HasColumnName("PSRNO")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.MarbiaStandardCode)
                .HasColumnName("MARBIA_STANDARD_CODE")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.PackageType)
                .HasColumnName("PACKAGE_TYPE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.SpecialRequest1)
                .HasColumnName("SPECIAL_REQUEST_1")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest2)
                .HasColumnName("SPECIAL_REQUEST_2")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.SpecialRequest3)
                .HasColumnName("SPECIAL_REQUEST_3")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest4)
                .HasColumnName("SPECIAL_REQUEST_4")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest5)
                .HasColumnName("SPECIAL_REQUEST_5")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest6)
                .HasColumnName("SPECIAL_REQUEST_6")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest7)
                .HasColumnName("SPECIAL_REQUEST_7")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest8)
                .HasColumnName("SPECIAL_REQUEST_8")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest9)
                .HasColumnName("SPECIAL_REQUEST_9")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest10)
                .HasColumnName("SPECIAL_REQUEST_10")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest11)
                .HasColumnName("SPECIAL_REQUEST_11")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest12)
                .HasColumnName("SPECIAL_REQUEST_12")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest13)
                .HasColumnName("SPECIAL_REQUEST_13")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest14)
                .HasColumnName("SPECIAL_REQUEST_14")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SpecialRequest15)
                .HasColumnName("SPECIAL_REQUEST_15")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.UseCode)
                .HasColumnName("USE_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.IsEnable)
                .IsRequired()
                .HasColumnName("IS_ENABLE")
                .HasColumnType("int(1)");

            builder.Property(t => t.CreateTime)
                .IsRequired()
                .HasColumnName("CREATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.CreateUser)
                .IsRequired()
                .HasColumnName("CREATE_USER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UpdateTime)
                .IsRequired()
                .HasColumnName("UPDATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.UpdateUser)
                .IsRequired()
                .HasColumnName("UPDATE_USER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Remark)
                .HasColumnName("REMARK")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckDelivery" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckDelivery" /></summary>
            public const string Name = "t_pl_truck_delivery";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.OperationMark" /></summary>
            public const string OperationMark = "OPERATION_MARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.DeliveryOrderNo" /></summary>
            public const string DeliveryOrderNo = "DELIVERY_ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.ItemCount" /></summary>
            public const string ItemCount = "ITEM_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.WeightTotal" /></summary>
            public const string WeightTotal = "WEIGHT_TOTAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.IsWeighting" /></summary>
            public const string IsWeighting = "IS_WEIGHTING";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.CustomerNo" /></summary>
            public const string CustomerNo = "CUSTOMER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.ChineseCustomer" /></summary>
            public const string ChineseCustomer = "CHINESE_CUSTOMER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.DeliveryType" /></summary>
            public const string DeliveryType = "DELIVERY_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SalesType" /></summary>
            public const string SalesType = "SALES_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.ProductType" /></summary>
            public const string ProductType = "PRODUCT_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.ProductTypeChinese" /></summary>
            public const string ProductTypeChinese = "PRODUCT_TYPE_CHINESE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.FreightBear" /></summary>
            public const string FreightBear = "FREIGHT_BEAR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.TransportType" /></summary>
            public const string TransportType = "TRANSPORT_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SourceHouse" /></summary>
            public const string SourceHouse = "SOURCE_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.DestHouse" /></summary>
            public const string DestHouse = "DEST_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SourceCode" /></summary>
            public const string SourceCode = "SOURCE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.DestCode" /></summary>
            public const string DestCode = "DEST_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SourcePortCode" /></summary>
            public const string SourcePortCode = "SOURCE_PORT_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.DestPortCode" /></summary>
            public const string DestPortCode = "DEST_PORT_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.PrivateLineCode" /></summary>
            public const string PrivateLineCode = "PRIVATE_LINE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.IsBillingTwo" /></summary>
            public const string IsBillingTwo = "IS_BILLING_TWO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.PortBatchNo" /></summary>
            public const string PortBatchNo = "PORT_BATCH_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.CarrierCompanyA" /></summary>
            public const string CarrierCompanyA = "CARRIER_COMPANY_A";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.CarrierCompanyB" /></summary>
            public const string CarrierCompanyB = "CARRIER_COMPANY_B";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.Note" /></summary>
            public const string Note = "NOTE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.ContractNo" /></summary>
            public const string ContractNo = "CONTRACT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.ContractItemNo" /></summary>
            public const string ContractItemNo = "CONTRACT_ITEM_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.DetailNo" /></summary>
            public const string DetailNo = "DETAIL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SteelGradeNo" /></summary>
            public const string SteelGradeNo = "STEEL_GRADE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.Thickness" /></summary>
            public const string Thickness = "THICKNESS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.Width" /></summary>
            public const string Width = "WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.Length" /></summary>
            public const string Length = "LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.Grade" /></summary>
            public const string Grade = "GRADE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.TypeCode" /></summary>
            public const string TypeCode = "TYPE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SizeMessage" /></summary>
            public const string SizeMessage = "SIZE_MESSAGE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SizeMessageChinese" /></summary>
            public const string SizeMessageChinese = "SIZE_MESSAGE_CHINESE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.PlanNo" /></summary>
            public const string PlanNo = "PLAN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.PlanWeight" /></summary>
            public const string PlanWeight = "PLAN_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.IsSpecifyCoilNo" /></summary>
            public const string IsSpecifyCoilNo = "IS_SPECIFY_COIL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.IsLast" /></summary>
            public const string IsLast = "IS_LAST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.OldPortBatchNo" /></summary>
            public const string OldPortBatchNo = "OLD_PORT_BATCH_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.Specification" /></summary>
            public const string Specification = "SPECIFICATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.CarType" /></summary>
            public const string CarType = "CAR_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.VirtualShipment" /></summary>
            public const string VirtualShipment = "VIRTUAL_SHIPMENT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.PieceWeightUpperLimit" /></summary>
            public const string PieceWeightUpperLimit = "PIECE_WEIGHT_UPPER_LIMIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.PieceWeightFloorLimit" /></summary>
            public const string PieceWeightFloorLimit = "PIECE_WEIGHT_FLOOR_LIMIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.Psrno" /></summary>
            public const string Psrno = "PSRNO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.MarbiaStandardCode" /></summary>
            public const string MarbiaStandardCode = "MARBIA_STANDARD_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.PackageType" /></summary>
            public const string PackageType = "PACKAGE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest1" /></summary>
            public const string SpecialRequest1 = "SPECIAL_REQUEST_1";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest2" /></summary>
            public const string SpecialRequest2 = "SPECIAL_REQUEST_2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest3" /></summary>
            public const string SpecialRequest3 = "SPECIAL_REQUEST_3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest4" /></summary>
            public const string SpecialRequest4 = "SPECIAL_REQUEST_4";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest5" /></summary>
            public const string SpecialRequest5 = "SPECIAL_REQUEST_5";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest6" /></summary>
            public const string SpecialRequest6 = "SPECIAL_REQUEST_6";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest7" /></summary>
            public const string SpecialRequest7 = "SPECIAL_REQUEST_7";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest8" /></summary>
            public const string SpecialRequest8 = "SPECIAL_REQUEST_8";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest9" /></summary>
            public const string SpecialRequest9 = "SPECIAL_REQUEST_9";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest10" /></summary>
            public const string SpecialRequest10 = "SPECIAL_REQUEST_10";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest11" /></summary>
            public const string SpecialRequest11 = "SPECIAL_REQUEST_11";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest12" /></summary>
            public const string SpecialRequest12 = "SPECIAL_REQUEST_12";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest13" /></summary>
            public const string SpecialRequest13 = "SPECIAL_REQUEST_13";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest14" /></summary>
            public const string SpecialRequest14 = "SPECIAL_REQUEST_14";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.SpecialRequest15" /></summary>
            public const string SpecialRequest15 = "SPECIAL_REQUEST_15";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.UseCode" /></summary>
            public const string UseCode = "USE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDelivery.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
