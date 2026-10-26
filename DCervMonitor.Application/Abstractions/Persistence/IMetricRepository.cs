using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCervMonitor.Domain.Entities;

namespace DCervMonitor.Application.Abstractions.Persistence
{
    public interface IMetricRepository
    {
        Task AddAsync(MetricSample metric,CancellationToken cancellationtoken = default);


    }
}
