using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HealthChecks
{
    public class ApiHealthCheck: IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                Random rand = new Random();

                if (rand.Next(0, 2) == 0)
                {
                    return new HealthCheckResult(HealthStatus.Healthy, "Succeeded");
                }
                else
                {
                    return new HealthCheckResult(HealthStatus.Unhealthy, "Failed");
                }
            }
            catch (Exception ex)
            {
                return new HealthCheckResult(HealthStatus.Unhealthy, "Failed", ex);
            }

        }

       
    }
}
