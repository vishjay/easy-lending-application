using System;
using System.Collections.Generic;
using System.Text;

namespace BorrowingPowerService.Domain.Services
{
    public class BorrowingCalculator
    {
        public decimal Calculate(int creditScore)
        {
            if (creditScore >= 800) return 1_000_000;
            if (creditScore >= 700) return 700_000;
            if (creditScore >= 600) return 400_000;
            return 100_000;
        }
    }
}
