using Contracts.Events;
using EventBus.Abstractions;
using ReadModelService.Application.Interfaces;
using ReadModelService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Worker.Consumers
{
    public class BorrowingPowerCalculatedConsumer : IConsumer<BorrowingPowerCalculated>
    {
        private readonly IProjection<BorrowingPowerCalculated> _projection;

        public BorrowingPowerCalculatedConsumer(IProjection<BorrowingPowerCalculated> projection)
        {
            _projection = projection;
        }

        public async Task Consume(BorrowingPowerCalculated message)
        {
            await _projection.Apply(message);
        }
    }
}
