using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCervMonitor.Domain.Entities;
using DCervMonitor.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DCervMonitor.Infrastructure.Persistence
{
    public class MonitorDbContext : DbContext
    {
        public MonitorDbContext(DbContextOptions<MonitorDbContext> options) : base(options)
        { }
        public DbSet<MetricSample> MetricSamples { get; set; }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MetricSampleConfiguration)
        }

    }
}
