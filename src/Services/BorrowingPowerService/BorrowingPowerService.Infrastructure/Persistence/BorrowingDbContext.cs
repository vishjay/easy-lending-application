using BorrowingPowerService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.BaseDbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorrowingPowerService.Infrastructure.Persistence
{
    public class BorrowingDbContext : BaseDbContext
    {
        public BorrowingDbContext(DbContextOptions<BorrowingDbContext> options)
            : base(options) { }

        public DbSet<BorrowingAssessment> Assessments => Set<BorrowingAssessment>();
    }
}
