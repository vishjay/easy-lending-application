using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace BorrowingPowerService.Application.Commands
{
    public record CalculateBorrowingCommand(
        Guid CustomerId,
        int CreditScore
    ) : IRequest<decimal>;
}
