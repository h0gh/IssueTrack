using System;

namespace SaasOvation.Common
{
    public interface IDomainEvent
    {
        int EventVersion { get; }

        DateTime OccurredOn { get; }
    }
}
