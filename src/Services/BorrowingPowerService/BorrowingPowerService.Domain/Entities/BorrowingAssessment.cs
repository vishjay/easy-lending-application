using System;
using System.Collections.Generic;
using System.Text;

namespace BorrowingPowerService.Domain.Entities
{
    public class BorrowingAssessment
    {
        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }
        public int CreditScore { get; private set; }
        public decimal BorrowingAmount { get; private set; }

        private BorrowingAssessment() { }

        public BorrowingAssessment(Guid customerId, int creditScore, decimal amount)
        {
            Id = Guid.NewGuid();
            CustomerId = customerId;
            CreditScore = creditScore;
            BorrowingAmount = amount;
        }
    }
}
