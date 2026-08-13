using CreditCheckService.Application.Interfaces;
using CreditCheckService.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCheckService.Application.Commands;

public class PerformCreditCheckHandler
    : IRequestHandler<PerformCreditCheckCommand, int>
{
    private readonly ICreditApi _api;
    private readonly ICreditRepository _repo;

    public PerformCreditCheckHandler(ICreditApi api, ICreditRepository repo)
    {
        _api = api;
        _repo = repo;
    }

    public async Task<int> Handle(
        PerformCreditCheckCommand request,
        CancellationToken cancellationToken)
    {
        var score = await _api.GetCreditScore(request.Name, request.Address);

        var profile = new CreditProfile(request.CustomerId, score);

        await _repo.AddAsync(profile);

        return score;
    }
}