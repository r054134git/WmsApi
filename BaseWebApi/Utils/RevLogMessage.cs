using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WmsApi.Domain.Entities;

namespace WmsApi.Utils
{
    public static class RevLogMessage
    {
        public static TRcLog RevLog(string mess)
        {
            var log = new TRcLog
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Dt = DateTime.Now,
                EventNo = "1000",
                Source = "API",
                WarningLevel = "INFO",
                Message = mess
            };
            return log;
        }
    }
}
