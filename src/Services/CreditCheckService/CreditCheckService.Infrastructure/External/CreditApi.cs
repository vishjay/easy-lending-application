using CreditCheckService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCheckService.Infrastructure.External;

public class CreditApi : ICreditApi
{
    public async Task<int> GetCreditScore(string name, string address)
    {
        // simulate external API
        await Task.Delay(500);

        return new Random().Next(300, 850);
    }
}
