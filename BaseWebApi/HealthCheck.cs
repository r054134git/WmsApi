using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MySqlConnector;
using WmsApi.Domain;

namespace WmsApi
{
    public class DbHealthCheck : IHealthCheck
    {
        private WmspcrContext _dataContext;

        public string Name => "sql";

        public DbHealthCheck(WmspcrContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await _dataContext.Database.CanConnectAsync();
				if (result)
				{
                    return HealthCheckResult.Healthy();
                }
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy("From MySQL Health Check");
            }
            return HealthCheckResult.Unhealthy("From MySQL Health Check");
        }
    }
}
