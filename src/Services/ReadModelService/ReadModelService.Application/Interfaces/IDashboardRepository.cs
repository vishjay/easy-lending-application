using ReadModelService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.Interfaces
{
    public interface IDashboardRepository
    {
        Task UpsertAsync(AdminDashboardView view);
    }
}
