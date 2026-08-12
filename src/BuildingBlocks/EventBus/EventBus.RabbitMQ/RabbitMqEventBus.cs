using EventBus.Abstractions;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBus.RabbitMQ
{
    public class RabbitMqEventBus<T> : IEventBus<T> where T : class
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public RabbitMqEventBus(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }
        public async Task Publish(T message)
        {
            await _publishEndpoint.Publish(message);
        }
    }
}
