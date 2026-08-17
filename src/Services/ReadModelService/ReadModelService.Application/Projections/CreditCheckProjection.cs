using Contracts.Events;
using ReadModelService.Application.Interfaces;
using ReadModelService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.Projections
{
    public class CreditCheckProjection: IProjection<CreditCheckCompleted>
    {
        private readonly IDashboardRepository _repository;

        public CreditCheckProjection(IDashboardRepository repository)
        {
            _repository = repository;
        }

        public async Task Apply(CreditCheckCompleted message)
        {
            var view = new AdminDashboardView
            {
                CustomerId = message.CustomerId,
                CreditScore = message.CreditScore,
                LastUpdated = DateTime.UtcNow
            };

            await _repository.UpsertAsync(view);
        }
    }
}
