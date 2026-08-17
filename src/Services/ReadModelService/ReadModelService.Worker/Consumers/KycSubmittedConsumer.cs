using Contracts.Events;
using EventBus.Abstractions;
using ReadModelService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Worker.Consumers
{
    public class KycSubmittedConsumer : IConsumer<KycSubmitted>
    {
        private readonly IProjection<KycSubmitted> _projection;

        public KycSubmittedConsumer(IProjection<KycSubmitted> projection)
        {
            _projection = projection;
        }

        public async Task Consume(KycSubmitted message)
        {
            await _projection.Apply(message);
        }
    }
}
