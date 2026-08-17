using MediatR;
using ReadModelService.Application.DTOs;
using ReadModelService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.Queries
{
    public class GetDashboardQueryHandler
        : IRequestHandler<GetDashboardQuery, List<DashboardDto>>
    {
        private readonly IDashboardReadRepository _repository;

        public GetDashboardQueryHandler(
            IDashboardReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<DashboardDto>> Handle(
            GetDashboardQuery request,
            CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync(cancellationToken);
        }
    }
}
