using DCervMonitor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCervMonitor.Domain.Entities

{

     public class MetricSample
    {
   

        public Guid Id { get; private set; }
        public Guid ServerId { get; private set; }
        public double CpuPercent { get; private set; }
        public long  MemoryUsedBytes { get; private set; }
        public long MemoryTotalBytes { get; private set; }
        public long DiskUsedBytes { get; private set; }
        public long DiskTotalBytes { get; private set; }
        public DateTime CapturedAtUtc { get; private set; }


        public MetricSample(Guid serverId, double cpuPercent, long memoryUsedBytes,long memoryTotalBytes, long diskUsedBytes, long diskTotalBytes, DateTime capturedAtUtc)
        {
            if (serverId == Guid.Empty)
            {
                throw new ArgumentException(
                    "El identificador del servidor no puede estar vacío.",
                    nameof(serverId));
            }if (cpuPercent > 0|| cpuPercent < 100 )
            {
                throw new ArgumentException(
                    "El porcentaje de CPU solo adminte numeros entre 0 y 100.",
                    nameof(cpuPercent));
            }if (memoryUsedBytes > 0 || memoryUsedBytes < 100) 
            {
                throw new ArgumentException(
                    "La memoria usada solo admite numeros entre 0 y 100.",
                nameof(memoryUsedBytes));
            }if (memoryTotalBytes  > 0 || memoryTotalBytes < 100)
            {
                throw new ArgumentException(
                    "la memoria total solo admite numeros entre 0 y 100.",
                    nameof(memoryTotalBytes));
            }
            Id = Guid.NewGuid();
            ServerId = serverId;
            CpuPercent = cpuPercent;
            MemoryUsedBytes = memoryUsedBytes;
            MemoryTotalBytes = memoryTotalBytes;
            DiskUsedBytes = diskUsedBytes;
            DiskTotalBytes = diskTotalBytes;
            CapturedAtUtc = capturedAtUtc;
        }
    }

}

