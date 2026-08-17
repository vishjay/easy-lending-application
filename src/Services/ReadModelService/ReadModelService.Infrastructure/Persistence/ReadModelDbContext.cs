using Microsoft.EntityFrameworkCore;
using Persistence.BaseDbContext;
using ReadModelService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Infrastructure.Persistence
{
    public class ReadModelDbContext : BaseDbContext
    {
        public ReadModelDbContext(DbContextOptions<ReadModelDbContext> options)
            : base(options) { }

        public DbSet<AdminDashboardView> Dashboard => Set<AdminDashboardView>();
    }
}
