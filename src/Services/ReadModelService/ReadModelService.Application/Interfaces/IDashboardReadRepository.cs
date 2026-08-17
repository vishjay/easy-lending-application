using ReadModelService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.Interfaces
{
    public interface IDashboardReadRepository
    {
        Task<List<DashboardDto>> GetAllAsync(
            CancellationToken cancellationToken);

        Task<DashboardDto?> GetByCustomerIdAsync(
            Guid customerId,
            CancellationToken cancellationToken);
    }
}
