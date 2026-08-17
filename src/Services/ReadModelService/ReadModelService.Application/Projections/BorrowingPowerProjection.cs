using Contracts.Events;
using ReadModelService.Application.Interfaces;
using ReadModelService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.Projections
{
    public  class BorrowingPowerProjection : IProjection<BorrowingPowerCalculated>
    {
        private readonly IDashboardRepository _repository;

        public BorrowingPowerProjection(IDashboardRepository repository)
        {
            _repository = repository;
        }

        public async Task Apply(BorrowingPowerCalculated message)
        {
            var view = new AdminDashboardView
            {
                CustomerId = message.CustomerId,
                BorrowingPower = message.Amount,
                LastUpdated = DateTime.UtcNow
            };

            await _repository.UpsertAsync(view);
        }
    }
}
