using System;
using FluentValidation;
using WmsApi.Contracts.Models;

namespace WmsApi.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="Tmmcr01CreateModel"/> .
    /// </summary>
    public partial class Tmmcr01CreateModelValidator
        : AbstractValidator<Tmmcr01CreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmmcr01CreateModelValidator"/> class.
        /// </summary>
        public Tmmcr01CreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.RecCreator).MaximumLength(24);
            RuleFor(p => p.RecCreateTime).MaximumLength(14);
            RuleFor(p => p.RecRevisor).MaximumLength(24);
            RuleFor(p => p.RecReviseTime).MaximumLength(14);
            RuleFor(p => p.RecErasor).MaximumLength(24);
            RuleFor(p => p.RecEraseTime).MaximumLength(14);
            RuleFor(p => p.ArchiveFlag).MaximumLength(1);
            RuleFor(p => p.ArchiveStampNo).MaximumLength(10);
            RuleFor(p => p.MatNo).MaximumLength(20);
            RuleFor(p => p.MatId).MaximumLength(20);
            RuleFor(p => p.MatTrackNo).MaximumLength(18);
            RuleFor(p => p.MatLineType).MaximumLength(4);
            RuleFor(p => p.MatKind).MaximumLength(2);
            RuleFor(p => p.UnitCode).MaximumLength(7);
            RuleFor(p => p.NextUnitCode).MaximumLength(7);
            RuleFor(p => p.FactoryDiv).MaximumLength(3);
            RuleFor(p => p.MatShapeFlag).MaximumLength(1);
            RuleFor(p => p.OriginMatNo).MaximumLength(20);
            RuleFor(p => p.RawOrigin).MaximumLength(6);
            RuleFor(p => p.MatOrigin).MaximumLength(2);
            RuleFor(p => p.MatDestion).MaximumLength(2);
            RuleFor(p => p.ProductFlag).MaximumLength(1);
            RuleFor(p => p.MatStatus).MaximumLength(2);
            RuleFor(p => p.MeasureWtFlag).MaximumLength(1);
            RuleFor(p => p.ProductPackFlag).MaximumLength(1);
            RuleFor(p => p.PackUnitCode).MaximumLength(10);
            RuleFor(p => p.PackTypeCode).MaximumLength(5);
            RuleFor(p => p.OrderPackTypeCode).MaximumLength(5);
            RuleFor(p => p.ProductPackTime).MaximumLength(14);
            RuleFor(p => p.PackShiftNo).MaximumLength(1);
            RuleFor(p => p.PackShiftGroup).MaximumLength(1);
            RuleFor(p => p.PackNo).MaximumLength(20);
            RuleFor(p => p.Pono).MaximumLength(20);
            RuleFor(p => p.HeatNo).MaximumLength(20);
            RuleFor(p => p.StNo).MaximumLength(20);
            RuleFor(p => p.ProdMaker).MaximumLength(24);
            RuleFor(p => p.ProdTime).MaximumLength(14);
            RuleFor(p => p.ProdShiftNo).MaximumLength(1);
            RuleFor(p => p.ProdShiftGroup).MaximumLength(1);
            RuleFor(p => p.StdSgCode).MaximumLength(6);
            RuleFor(p => p.SgSign).MaximumLength(50);
            RuleFor(p => p.SgStd).MaximumLength(100);
            RuleFor(p => p.SgCode).MaximumLength(20);
            RuleFor(p => p.OldStdSgCode).MaximumLength(10);
            RuleFor(p => p.OldSgStd).MaximumLength(100);
            RuleFor(p => p.OldSgSign).MaximumLength(50);
            RuleFor(p => p.WholeBacklogAct).MaximumLength(100);
            RuleFor(p => p.FinalCoilFlag).MaximumLength(1);
            RuleFor(p => p.TailFlag).MaximumLength(1);
            RuleFor(p => p.OrderNo).MaximumLength(20);
            RuleFor(p => p.OldOrderNo).MaximumLength(20);
            RuleFor(p => p.DelivyDate).MaximumLength(8);
            RuleFor(p => p.FinCustCode).MaximumLength(12);
            RuleFor(p => p.WholeBacklog).MaximumLength(100);
            RuleFor(p => p.WholeBacklogCode).MaximumLength(5);
            RuleFor(p => p.NextWholeBacklogCode).MaximumLength(5);
            RuleFor(p => p.Msc).MaximumLength(20);
            RuleFor(p => p.OldMsc).MaximumLength(20);
            RuleFor(p => p.MscLineNo).MaximumLength(4);
            RuleFor(p => p.OldMscLine).MaximumLength(4);
            RuleFor(p => p.Psc).MaximumLength(25);
            RuleFor(p => p.OldPsc).MaximumLength(25);
            RuleFor(p => p.Apn).MaximumLength(4);
            RuleFor(p => p.OldApn).MaximumLength(4);
            RuleFor(p => p.ProdReadyDate).MaximumLength(8);
            RuleFor(p => p.BillOfLadingNo).MaximumLength(13);
            RuleFor(p => p.ContractNum).MaximumLength(20);
            RuleFor(p => p.MatDisposeCode).MaximumLength(1);
            RuleFor(p => p.DisposeShiftNo).MaximumLength(1);
            RuleFor(p => p.DisposeShiftGroup).MaximumLength(1);
            RuleFor(p => p.HoldFlag).MaximumLength(1);
            RuleFor(p => p.HoldCauseCode).MaximumLength(4);
            RuleFor(p => p.HoldTime).MaximumLength(14);
            RuleFor(p => p.HoldMaker).MaximumLength(24);
            RuleFor(p => p.HoldRemark).MaximumLength(300);
            RuleFor(p => p.RelMaker).MaximumLength(24);
            RuleFor(p => p.RelRemark).MaximumLength(300);
            RuleFor(p => p.RelTime).MaximumLength(14);
            RuleFor(p => p.RemainCauseCode).MaximumLength(4);
            RuleFor(p => p.RemainDecideCode).MaximumLength(4);
            RuleFor(p => p.RemainDecideMaker).MaximumLength(24);
            RuleFor(p => p.RemainDecideTime).MaximumLength(14);
            RuleFor(p => p.RemainRemark).MaximumLength(300);
            RuleFor(p => p.DropLevelType).MaximumLength(2);
            RuleFor(p => p.DropLevelRemark).MaximumLength(300);
            RuleFor(p => p.DropLevelCauseCode).MaximumLength(2);
            RuleFor(p => p.ScrapCauseCode).MaximumLength(4);
            RuleFor(p => p.ScrapRemark).MaximumLength(300);
            RuleFor(p => p.ScrapTime).MaximumLength(14);
            RuleFor(p => p.ScrapMaker).MaximumLength(24);
            RuleFor(p => p.RepairFlag).MaximumLength(1);
            RuleFor(p => p.RepairBacklogCode).MaximumLength(5);
            RuleFor(p => p.RepairRemark).MaximumLength(300);
            RuleFor(p => p.RepairType).MaximumLength(3);
            RuleFor(p => p.MatRepairReason).MaximumLength(4);
            RuleFor(p => p.SurfaceDecideCode).MaximumLength(1);
            RuleFor(p => p.SurfaceDecideTime).MaximumLength(14);
            RuleFor(p => p.SurfaceDecideMaker).MaximumLength(24);
            RuleFor(p => p.ComplexDecideCode).MaximumLength(1);
            RuleFor(p => p.ComplexDecideTime).MaximumLength(14);
            RuleFor(p => p.ComplexDecideMaker).MaximumLength(24);
            RuleFor(p => p.OldComplexDecideCode).MaximumLength(1);
            RuleFor(p => p.OldComplexDecideTime).MaximumLength(14);
            RuleFor(p => p.OldComplexDecideMaker).MaximumLength(24);
            RuleFor(p => p.NewTestNo).MaximumLength(6);
            RuleFor(p => p.SampleLotNo).MaximumLength(12);
            RuleFor(p => p.SampleTakenFlag).MaximumLength(1);
            RuleFor(p => p.DefectCode).MaximumLength(5);
            RuleFor(p => p.DefectClass).MaximumLength(2);
            RuleFor(p => p.PlanNo).MaximumLength(10);
            RuleFor(p => p.TransferFlag).MaximumLength(1);
            RuleFor(p => p.TransferPlanNo).MaximumLength(15);
            RuleFor(p => p.TransferRejectCause).MaximumLength(100);
            RuleFor(p => p.TransferMaker).MaximumLength(24);
            RuleFor(p => p.TransferTime).MaximumLength(14);
            RuleFor(p => p.AppDecideFlag).MaximumLength(1);
            RuleFor(p => p.AppDecideNo).MaximumLength(10);
            RuleFor(p => p.AppDecideMaker).MaximumLength(24);
            RuleFor(p => p.StockPlaceNo).MaximumLength(15);
            RuleFor(p => p.StockNo).MaximumLength(3);
            RuleFor(p => p.HallNo).MaximumLength(5);
            RuleFor(p => p.Rowno).MaximumLength(4);
            RuleFor(p => p.ColumnNo).MaximumLength(3);
            RuleFor(p => p.Layerno).MaximumLength(5);
            RuleFor(p => p.InFlag).MaximumLength(1);
            RuleFor(p => p.InStockTime).MaximumLength(14);
            RuleFor(p => p.OutStockTime).MaximumLength(14);
            RuleFor(p => p.CmdFlag).MaximumLength(1);
            RuleFor(p => p.StockPlaceNoPre).MaximumLength(15);
            RuleFor(p => p.ChooseFlag).MaximumLength(1);
            RuleFor(p => p.SkidNo).MaximumLength(10);
            RuleFor(p => p.InMatNo1).MaximumLength(20);
            RuleFor(p => p.InMatNo2).MaximumLength(20);
            RuleFor(p => p.InMat1TrackNo).MaximumLength(18);
            RuleFor(p => p.InMat2TrackNo).MaximumLength(18);
            RuleFor(p => p.BetterSurfWardCode).MaximumLength(1);
            RuleFor(p => p.AnnealDiagramCode).MaximumLength(3);
            RuleFor(p => p.TopPlateTypeCode).MaximumLength(2);
            RuleFor(p => p.BotPlateTypeCode).MaximumLength(2);
            RuleFor(p => p.OilKindCode).MaximumLength(2);
            RuleFor(p => p.OilQtyCode).MaximumLength(2);
            RuleFor(p => p.TopStrucCode).MaximumLength(2);
            RuleFor(p => p.BotStrucCode).MaximumLength(2);
            RuleFor(p => p.DummyCoilFlag).MaximumLength(1);
            RuleFor(p => p.MatReturnFlag).MaximumLength(1);
            RuleFor(p => p.MatReturnCauseCode).MaximumLength(5);
            RuleFor(p => p.MatUnionFlag).MaximumLength(1);
            RuleFor(p => p.TrimFlag).MaximumLength(1);
            RuleFor(p => p.PostProcCode).MaximumLength(2);
            RuleFor(p => p.ProdCode).MaximumLength(5);
            RuleFor(p => p.ProdCname).MaximumLength(200);
            RuleFor(p => p.ProdEname).MaximumLength(200);
            RuleFor(p => p.SurfaceGradeCode).MaximumLength(4);
            RuleFor(p => p.SortGradeCode).MaximumLength(1);
            RuleFor(p => p.SurfaceAccuCode).MaximumLength(4);
            RuleFor(p => p.StaggerWinding).MaximumLength(2);
            RuleFor(p => p.CorrectionCauseCode).MaximumLength(4);
            RuleFor(p => p.CorrectionMaker).MaximumLength(24);
            RuleFor(p => p.CorrectionTime).MaximumLength(14);
            RuleFor(p => p.CorrectRemark).MaximumLength(300);
            RuleFor(p => p.BackC1).MaximumLength(20);
            RuleFor(p => p.BackC2).MaximumLength(20);
            RuleFor(p => p.BackC3).MaximumLength(20);
            RuleFor(p => p.BackC4).MaximumLength(20);
            RuleFor(p => p.BackC5).MaximumLength(20);
            RuleFor(p => p.BackC6).MaximumLength(300);
            RuleFor(p => p.BackC7).MaximumLength(100);
            RuleFor(p => p.BackC8).MaximumLength(300);
            RuleFor(p => p.BackC9).MaximumLength(100);
            RuleFor(p => p.BackC10).MaximumLength(100);
            RuleFor(p => p.Labelname).MaximumLength(50);
            RuleFor(p => p.StockingPeriod).MaximumLength(8);
            RuleFor(p => p.AutoJudge).MaximumLength(1);
            RuleFor(p => p.FinCustCname).MaximumLength(200);
            RuleFor(p => p.PsYn).MaximumLength(1);
            RuleFor(p => p.ZincSufaceCl).MaximumLength(20);
            RuleFor(p => p.SkpMode).MaximumLength(1);
            RuleFor(p => p.Spangle).MaximumLength(10);
            RuleFor(p => p.Preparestus).MaximumLength(5);
            #endregion
        }

    }
}
