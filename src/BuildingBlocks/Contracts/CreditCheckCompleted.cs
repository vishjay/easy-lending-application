using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Events;

public record CreditCheckCompleted(
    Guid CustomerId,
    int CreditScore
) : IntegrationEventBase;
