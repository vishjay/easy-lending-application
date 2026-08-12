using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Events
{
    public record KycSubmitted(
        Guid CustomerId,
    string Name,
    string Address) : IntegrationEventBase;
}
