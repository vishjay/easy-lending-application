using MediatR;
using ReadModelService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.Queries
{
    public record GetDashboardQuery()
        : IRequest<List<DashboardDto>>;
}
