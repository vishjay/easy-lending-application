using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CreditCheckService.Application.Commands;

public record PerformCreditCheckCommand(
    Guid CustomerId,
    string Name,
    string Address
) : IRequest<int>;
