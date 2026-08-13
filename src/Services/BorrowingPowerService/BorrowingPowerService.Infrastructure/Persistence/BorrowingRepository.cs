using BorrowingPowerService.Application.Interfaces;
using BorrowingPowerService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorrowingPowerService.Infrastructure.Persistence
{
    public class BorrowingRepository : IBorrowingRepository
    {
        private readonly BorrowingDbContext _db;

        public BorrowingRepository(BorrowingDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(BorrowingAssessment assessment)
        {
            _db.Assessments.Add(assessment);
            await _db.SaveChangesAsync();
        }
    }
}
