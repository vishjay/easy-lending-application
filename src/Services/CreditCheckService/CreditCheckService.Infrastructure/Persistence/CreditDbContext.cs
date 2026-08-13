using CreditCheckService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.BaseDbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCheckService.Infrastructure.Persistence;

public class CreditDbContext : BaseDbContext
{
    public CreditDbContext(DbContextOptions<CreditDbContext> options)
        : base(options) { }

    public DbSet<CreditProfile> CreditProfiles => Set<CreditProfile>();
}
