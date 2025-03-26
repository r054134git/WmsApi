using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cds.Contracts;
using Contracts;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Wms.Telegram;
using WmsApi;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace ApiPlan
{
    public class PlanConsumer : IConsumer<AutoPrePickConfirm>
    {
        private readonly ILogger<PlanConsumer> _logger;
        private readonly IHubContext<ChatHub> _hubContext;
        public PlanConsumer(ILogger<PlanConsumer> logger, IHubContext<ChatHub> hubContext)
        {
            _logger = logger;
            _hubContext = hubContext;
        }

        public async Task Consume(ConsumeContext<AutoPrePickConfirm> context)
        {
            var message = context.Message;
            _logger?.LogInformation($"接收到自动配载信息，显示标题：{message.Title}");
            await SendClient(message, message.IsRead, message.Title);
            _logger?.LogInformation($"推送前端成功，车号：{message.TruckNo}");
        }
        private async Task AutoPrePickConfirm()
        {
            try
            {
                //    var dataContext= _serviceProvider.GetService<WmspcrContext>();
                //    var plLoadList = await dataContext.Set<TPlTruckLoadList>()
                //.FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == confirm.TruckNo && t.TruckLoadingNo == confirm.TruckLoadingNo && t.DetailNo == confirm.DetailNo);
                //    if (plLoadList == null)
                //    {
                //        string title = $"自动配载完成,车号{confirm.TruckNo},装车单号{confirm.TruckLoadingNo},明细号{confirm.DetailNo},不存在,请人工核实确认";
                //        _logger?.LogInformation(title);
                //    }

                //    if (plLoadList.ResolveState == 1) //人工已确认
                //    {
                //        _logger?.LogInformation($"自动配载完成，车号{confirm.TruckNo},装车单号{confirm.TruckLoadingNo},明细号{confirm.DetailNo}，人工已确认");
                //    }

                //    if (!confirm.IsPrePickSuc) //自动配载失败 必须人工确认
                //    {
                //        string title = $"自动配载失败，车号{confirm.TruckNo},装车单号{confirm.TruckLoadingNo},明细号{confirm.DetailNo}，请人工核实确认";
                //        _logger?.LogInformation(title);
                //        await SendClient(confirm, false, title);
                //    }

                //    plLoadList.ResolveState = 1;
                //    plLoadList.UpdateUser = "Auto-Pre";
                //    plLoadList.UpdateTime = DateTime.Now;
                //    var plMaterials = await dataContext.Set<VPlMaterial>().Where(t => t.TruckLoadListId == plLoadList.Id).ToListAsync();
                //    string parkingSpace = "";
                //    if (plMaterials != null && plMaterials.Count > 0)
                //    {
                //        var bayList = plMaterials.Select(t => t.BayCode).Distinct();
                //        var parkingList = dataContext.Set<TTrParkingPlace>().Where(t => bayList.Contains(t.BayCode) && t.IsUsing == 0).ToList();
                //        if (parkingList != null && parkingList.Count > 0)
                //        {
                //            parkingSpace = parkingList.OrderBy(t => t.BayCode).FirstOrDefault().ParkingPlaceId;
                //        }

                //        var trTruck = await dataContext.Set<TTrTruck>()
                //        .FirstOrDefaultAsync(t => t.TruckNo == confirm.TruckNo && t.MainTruckLoadingNo == plLoadList.MainTruckLoadingNo);
                //        if (trTruck != null)
                //        {
                //            if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList))
                //            {
                //                foreach (var bay in bayList)
                //                {
                //                    if (!trTruck.LoadBayCodeList.Contains(bay))
                //                    {
                //                        trTruck.LoadBayCodeList = trTruck.LoadBayCodeList + "," + bay;
                //                    }
                //                }
                //            }
                //            else
                //            {
                //                trTruck.LoadBayCodeList = string.Join(",", bayList);
                //            }
                //            trTruck.ParkingNoSuggest = parkingSpace;
                //            trTruck.EnterTime = DateTime.Now;  //此处由于存在持卡开单没有入厂时间，默认预挑库完成后即入厂
                //            trTruck.DispatchState = 1;
                //        }
                //    }
                //    await dataContext.SaveChangesAsync();

                //根据MES业务移库装车清单无需发送MES
                //if (!plLoadList.DeliveryOrderNo.StartsWith("W"))
                //{
                //    var mbs = _serviceProvider.GetService<MbsProxy>();
                //    var teleWMBM10 = new TeleWMBM10
                //    {
                //        Payload = new ParkingSpaceInfo
                //        {
                //            MainTruckLoadingNo = plLoadList.MainTruckLoadingNo,
                //            TruckLoadingNo = plLoadList.TruckLoadingNo,
                //            OrderNo = plLoadList.OrderNo,
                //            DetailNo = plLoadList.DetailNo,
                //            VehicleNo = plLoadList.VehicleNo,
                //            House = plLoadList.SourceHouse,
                //            ParkingSpace = parkingSpace  //根据挑库钢卷bay排序后第一个车位
                //        }
                //    };
                //    await mbs.Publish(teleWMBM10);
                //}
                //string title1 = $"自动配载完成，车号{confirm.TruckNo},装车单号{confirm.TruckLoadingNo},明细号{confirm.DetailNo}，超时已自动确认";
                //_logger?.LogInformation(title1);
                //await SendClient(confirm, false, title1);
            }
            catch (Exception ex)
            {
                _logger?.LogError($"错误异常{ex.Message}");
            }

            #region 在用方法

            try
            {
                //while (true)
                //{
                //    if (GlobalBuffer.PrePickList.Count == 0)
                //        continue;

                //    //自动确认预挑库
                //    var dataContext = _serviceProvider.GetService<WmspcrContext>();
                //    foreach (AutoPrePickConfirm confirm in GlobalBuffer.PrePickList)
                //    {
                //        //自动确认预挑库
                //        if ((DateTime.Now - confirm.PrePickTime).TotalMinutes >= 1)
                //        {
                //            var plLoadList = await dataContext.Set<TPlTruckLoadList>()
                //    .FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == confirm.TruckNo && t.TruckLoadingNo == confirm.TruckLoadingNo && t.DetailNo == confirm.DetailNo);
                //            if (plLoadList == null)
                //            {
                //                string title = $"自动配载完成,车号{confirm.TruckNo},装车单号{confirm.TruckLoadingNo},明细号{confirm.DetailNo},不存在,请人工核实确认";
                //                _logger?.LogInformation(title);
                //                GlobalBuffer.PrePickList.Remove(confirm);
                //                continue;
                //            }

                //            if (plLoadList.ResolveState == 1) //人工已确认
                //            {
                //                _logger?.LogInformation($"自动配载完成，车号{confirm.TruckNo},装车单号{confirm.TruckLoadingNo},明细号{confirm.DetailNo}，人工已确认");
                //                GlobalBuffer.PrePickList.Remove(confirm);
                //                continue;
                //            }

                //            if (!confirm.IsPrePickSuc) //自动配载失败 必须人工确认
                //            {
                //                string title = $"自动配载失败，车号{confirm.TruckNo},装车单号{confirm.TruckLoadingNo},明细号{confirm.DetailNo}，请人工核实确认";
                //                _logger?.LogInformation(title);
                //                await SendClient(confirm, false, title);
                //                continue;
                //            }

                //            plLoadList.ResolveState = 1;
                //            plLoadList.UpdateUser = "Auto-Pre";
                //            plLoadList.UpdateTime = DateTime.Now;
                //            var plMaterials = await dataContext.Set<VPlMaterial>().Where(t => t.TruckLoadListId == plLoadList.Id).ToListAsync();
                //            string parkingSpace = "";
                //            if (plMaterials != null && plMaterials.Count > 0)
                //            {
                //                var bayList = plMaterials.Select(t => t.BayCode).Distinct();
                //                var parkingList = dataContext.Set<TTrParkingPlace>().Where(t => bayList.Contains(t.BayCode) && t.IsUsing == 0).ToList();
                //                if (parkingList != null && parkingList.Count > 0)
                //                {
                //                    parkingSpace = parkingList.OrderBy(t => t.BayCode).FirstOrDefault().ParkingPlaceId;
                //                }

                //                var trTruck = await dataContext.Set<TTrTruck>()
                //                .FirstOrDefaultAsync(t => t.TruckNo == confirm.TruckNo && t.MainTruckLoadingNo == plLoadList.MainTruckLoadingNo);
                //                if (trTruck != null)
                //                {
                //                    if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList))
                //                    {
                //                        foreach (var bay in bayList)
                //                        {
                //                            if (!trTruck.LoadBayCodeList.Contains(bay))
                //                            {
                //                                trTruck.LoadBayCodeList = trTruck.LoadBayCodeList + "," + bay;
                //                            }
                //                        }
                //                    }
                //                    else
                //                    {
                //                        trTruck.LoadBayCodeList = string.Join(",", bayList);
                //                    }
                //                    trTruck.ParkingNoSuggest = parkingSpace;
                //                    trTruck.EnterTime = DateTime.Now;  //此处由于存在持卡开单没有入厂时间，默认预挑库完成后即入厂
                //                    trTruck.DispatchState = 1;
                //                }
                //            }
                //            await dataContext.SaveChangesAsync();

                //            //根据MES业务移库装车清单无需发送MES
                //            if (!plLoadList.DeliveryOrderNo.StartsWith("W"))
                //            {
                //                var mbs = _serviceProvider.GetService<MbsProxy>();
                //                var teleWMBM10 = new TeleWMBM10
                //                {
                //                    Payload = new ParkingSpaceInfo
                //                    {
                //                        MainTruckLoadingNo = plLoadList.MainTruckLoadingNo,
                //                        TruckLoadingNo = plLoadList.TruckLoadingNo,
                //                        OrderNo = plLoadList.OrderNo,
                //                        DetailNo = plLoadList.DetailNo,
                //                        VehicleNo = plLoadList.VehicleNo,
                //                        House = plLoadList.SourceHouse,
                //                        ParkingSpace = parkingSpace  //根据挑库钢卷bay排序后第一个车位
                //                    }
                //                };
                //                await mbs.Publish(teleWMBM10);
                //            }
                //            string title1 = $"自动配载完成，车号{confirm.TruckNo},装车单号{confirm.TruckLoadingNo},明细号{confirm.DetailNo}，超时已自动确认";
                //            _logger?.LogInformation(title1);
                //            GlobalBuffer.PrePickList.Remove(confirm);
                //            await SendClient(confirm, false, title1);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                _logger?.LogError($"错误异常{ex.Message}");
            }

            #endregion

        }

        private async Task SendClient(AutoPrePickConfirm confirmInfo, bool read, string title)
        {
            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Title = title,
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = read,
                Type=MessageType.AutoPrePickCoils.ToString(),
                Data = confirmInfo,
            };
            await _hubContext.Clients.All.SendAsync("PrePickConfirm", noticeIconItem);
        }
    }
}
