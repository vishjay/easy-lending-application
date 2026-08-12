using System;
using System.Collections.Generic;
using System.Text;

namespace EventBus.Abstractions
{
    public interface IConsumer<T> where T : class
    {
        public Task Consume(T message);
    }
}
