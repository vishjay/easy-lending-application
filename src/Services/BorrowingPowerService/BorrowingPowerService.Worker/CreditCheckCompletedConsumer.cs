using System;
using System.Collections.Generic;
using System.Text;
using BorrowingPowerService.Application.Commands;
using Contracts.Events;
using EventBus.Abstractions;
using MediatR;

namespace BorrowingPowerService.Worker
{
    public class CreditCheckCompletedConsumer
        : IConsumer<CreditCheckCompleted>
    {
        private readonly IMediator _mediator;
        private readonly IEventBus<BorrowingPowerCalculated> _bus;

        public CreditCheckCompletedConsumer(
            IMediator mediator,
            IEventBus<BorrowingPowerCalculated> bus)
        {
            _mediator = mediator;
            _bus = bus;
        }

        public async Task Consume(CreditCheckCompleted message)
        {
            var amount = await _mediator.Send(
                new CalculateBorrowingCommand(
                    message.CustomerId,
                    message.CreditScore));

            await _bus.Publish(new BorrowingPowerCalculated(
                message.CustomerId,
                amount));
        }
    }
}
