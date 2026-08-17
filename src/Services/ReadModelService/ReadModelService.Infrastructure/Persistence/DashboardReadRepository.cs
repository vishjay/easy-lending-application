using Microsoft.EntityFrameworkCore;
using ReadModelService.Application.DTOs;
using ReadModelService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Infrastructure.Persistence
{
    public class DashboardReadRepository
        : IDashboardReadRepository
    {
        private readonly ReadModelDbContext _db;

        public DashboardReadRepository(ReadModelDbContext db)
        {
            _db = db;
        }

        public async Task<List<DashboardDto>> GetAllAsync(
            CancellationToken cancellationToken)
        {
            return await _db.Dashboard
                .AsNoTracking()
                .Select(x => new DashboardDto
                {
                    CustomerId = x.CustomerId,
                    Name = x.Name,
                    Address = x.Address,
                    CreditScore = x.CreditScore,
                    BorrowingPower = x.BorrowingPower
                })
                .ToListAsync(cancellationToken);
        }

        public async Task<DashboardDto?> GetByCustomerIdAsync(
            Guid customerId,
            CancellationToken cancellationToken)
        {
            return await _db.Dashboard.Where(d => d.CustomerId == customerId)
                .AsNoTracking()
                .Select(x => new DashboardDto
                {
                    CustomerId = x.CustomerId,
                    Name = x.Name,
                    Address = x.Address,
                    CreditScore = x.CreditScore,
                    BorrowingPower = x.BorrowingPower
                })
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
