using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.DTOs
{
    public class DashboardDto
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int? CreditScore { get; set; }
        public decimal? BorrowingPower { get; set; }
    }
}
