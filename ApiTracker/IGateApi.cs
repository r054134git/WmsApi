using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Threading.Tasks;
using WmsApi.Contracts;

namespace ApiTracker
{
    public interface IGateApi
    {
        [Post("/ipms/subSystem/control/sluice")]
        Task<GateControlResult> GateControl(GateControlParas para, [Header("AccessToken")] string authorization);
    }
}
