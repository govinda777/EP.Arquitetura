using System;

namespace Kernel.Domain.Core.Interfaces
{
    public interface IDomainEvent
    {
        int Versao { get; set; }
        DateTime DataOcorrencia { get; }
    }
}