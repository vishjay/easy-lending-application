using CreditCheckService.Application.Interfaces;
using CreditCheckService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCheckService.Infrastructure.Persistence;

public class CreditRepository : ICreditRepository
{
    private readonly CreditDbContext _db;

    public CreditRepository(CreditDbContext db)
    {
        _db = db;
    }

    public async Task AddAsync(CreditProfile profile)
    {
        _db.CreditProfiles.Add(profile);
        await _db.SaveChangesAsync();
    }
}
