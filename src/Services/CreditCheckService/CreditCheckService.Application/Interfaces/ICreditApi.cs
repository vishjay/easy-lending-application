using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCheckService.Application.Interfaces;

public interface ICreditApi
{
    Task<int> GetCreditScore(string name, string address);
}
