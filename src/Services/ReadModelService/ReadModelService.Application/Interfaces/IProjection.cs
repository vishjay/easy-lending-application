using Contracts.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.Interfaces
{
    public interface IProjection<T> where T : class
    {
        Task Apply(T message);
    }
}
