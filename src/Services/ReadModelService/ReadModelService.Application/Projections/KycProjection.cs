using Contracts.Events;
using ReadModelService.Application.Interfaces;
using ReadModelService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.Projections
{
    public class KycProjection : IProjection<KycSubmitted>
    {
        private readonly IDashboardRepository _repository;

        public KycProjection(IDashboardRepository repository)
        {
            _repository = repository;
        }

        public async Task Apply(KycSubmitted message)
        {
            var view = new AdminDashboardView
            {
                CustomerId = message.CustomerId,
                Name = message.Name,
                Address = message.Address,
                LastUpdated = DateTime.UtcNow
            };

            await _repository.UpsertAsync(view);
        }
    }
}
