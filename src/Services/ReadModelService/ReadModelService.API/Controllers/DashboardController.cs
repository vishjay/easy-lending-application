using Microsoft.AspNetCore.Mvc;
using MediatR;
using ReadModelService.Application.Queries;

namespace ReadModelService.API.Controllers
{
    [ApiController]
    [Route("api/dashboard")]
    public class DashboardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DashboardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(
            CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(
                new GetDashboardQuery(),
                cancellationToken);

            return Ok(result);
        }

        [HttpGet("{customerId:guid}")]
        public async Task<IActionResult> GetByCustomer(
            Guid customerId,
            CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(
                new GetDashboardByCustomerQuery(customerId),
                cancellationToken);

            return result is null
                ? NotFound()
                : Ok(result);
        }
    }
}
