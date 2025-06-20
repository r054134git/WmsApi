using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Threading.Tasks;
using WmsApi.Contracts;

namespace ApiTracker
{
    public interface IGateTokenApi
    {
        [Get("/ipms/subSystem/generate/token")]
        Task<GateTokenResult> GetToken(string userName);
    }
}
