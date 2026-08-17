using ReadModelService.Application.Interfaces;
using ReadModelService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Infrastructure.Persistence
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly ReadModelDbContext _db;

        public DashboardRepository(ReadModelDbContext db)
        {
            _db = db;
        }

        public async Task UpsertAsync(AdminDashboardView view)
        {
            var existing = await _db.Dashboard.FindAsync(view.CustomerId);

            if (existing == null)
            {
                _db.Dashboard.Add(view);
            }
            else
            {
                existing.Name = view.Name ?? existing.Name;
                existing.Address = view.Address ?? existing.Address;
                existing.CreditScore = view.CreditScore ?? existing.CreditScore;
                existing.BorrowingPower = view.BorrowingPower ?? existing.BorrowingPower;
                existing.LastUpdated = DateTime.UtcNow;
            }

            await _db.SaveChangesAsync();
        }
    }
}
