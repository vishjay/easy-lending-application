using Contracts.Events;
using CreditCheckService.Application.Commands;
using EventBus.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCheckService.Worker;

public class KycSubmittedConsumer : IConsumer<KycSubmitted>
{
    private readonly IMediator _mediator;
    private readonly IEventBus<CreditCheckCompleted> _bus;

    public KycSubmittedConsumer(IMediator mediator, IEventBus<CreditCheckCompleted> bus)
    {
        _mediator = mediator;
        _bus = bus;
    }

    public async Task Consume(KycSubmitted message)
    {
        var score = await _mediator.Send(
            new PerformCreditCheckCommand(
                message.CustomerId,
                message.Name,
                message.Address));

        await _bus.Publish(new CreditCheckCompleted(
            message.CustomerId,
            score));
    }
}
