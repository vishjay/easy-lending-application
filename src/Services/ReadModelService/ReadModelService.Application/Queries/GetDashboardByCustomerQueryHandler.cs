using MediatR;
using ReadModelService.Application.DTOs;
using ReadModelService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadModelService.Application.Queries
{
    public class GetDashboardByCustomerQueryHandler
    : IRequestHandler<GetDashboardByCustomerQuery, DashboardDto?>
    {
        private readonly IDashboardReadRepository _repository;

        public GetDashboardByCustomerQueryHandler(
            IDashboardReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<DashboardDto?> Handle(
            GetDashboardByCustomerQuery request,
            CancellationToken cancellationToken)
        {
           return await _repository.GetByCustomerIdAsync(request.CustomerId, cancellationToken);
        }
    }
}
