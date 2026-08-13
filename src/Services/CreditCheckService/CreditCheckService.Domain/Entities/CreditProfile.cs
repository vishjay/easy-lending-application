using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCheckService.Domain.Entities;

public class CreditProfile
{
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public int Score { get; private set; }

    private CreditProfile() { }

    public CreditProfile(Guid customerId, int score)
    {
        Id = Guid.NewGuid();
        CustomerId = customerId;
        Score = score;
    }
}