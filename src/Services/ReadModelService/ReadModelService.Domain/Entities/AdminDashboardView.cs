using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Domain.Entities
{
    public class AdminDashboardView
    {
        public Guid CustomerId { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public int? CreditScore { get; set; }
        public decimal? BorrowingPower { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
