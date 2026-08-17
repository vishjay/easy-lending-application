using Contracts.Events;
using EventBus.Abstractions;
using ReadModelService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Worker.Consumers
{
    public class CreditCheckCompletedConsumer : IConsumer<CreditCheckCompleted>
    {
        private readonly IProjection<CreditCheckCompleted> _projection;

        public CreditCheckCompletedConsumer(IProjection<CreditCheckCompleted> projection)
        {
            _projection = projection;
        }

        public async Task Consume(CreditCheckCompleted message)
        {
            await _projection.Apply(message);
        }
    }
}
