using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Events;

public record BorrowingPowerCalculated(
    Guid CustomerId,
    decimal Amount
) : IntegrationEventBase;
