using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCervMonitor.Domain.Entities;
using DCervMonitor.Application.Abstractions.Persistence;
using DCervMonitor.Infrastructure.Persistence;



namespace DCervMonitor.Infrastructure.Repositories
{
    public class MetricRepository : IMetricRepository
    {
        private readonly MonitorDbContext _context;

        public MetricRepository(MonitorDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(
            MetricSample metric,
            CancellationToken cancellationToken = default)
        {
            await _context.MetricSamples.AddAsync(
                metric, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);
        }

    }
}
