using CreditCheckService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCheckService.Application.Interfaces;

public interface ICreditRepository
{
    Task AddAsync(CreditProfile profile);
}
