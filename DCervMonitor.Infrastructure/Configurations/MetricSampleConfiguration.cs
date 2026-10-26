using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCervMonitor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCervMonitor.Infrastructure.Configurations
{
    public class MetricSampleConfiguration : IEntityTypeConfiguration<MetricSample>
    {
        public void Configure(EntityTypeBuilder<MetricSample> builder)
        {
            builder.ToTable("MetricSamples");

            builder.HasKey(x => x.Id);
        }
    }
}
