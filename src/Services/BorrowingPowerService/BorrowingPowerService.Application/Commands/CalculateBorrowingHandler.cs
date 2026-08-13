using BorrowingPowerService.Application.Interfaces;
using BorrowingPowerService.Domain.Entities;
using BorrowingPowerService.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorrowingPowerService.Application.Commands
{
    public class CalculateBorrowingHandler
        : IRequestHandler<CalculateBorrowingCommand, decimal>
    {
        private readonly BorrowingCalculator _calculator;
        private readonly IBorrowingRepository _repo;

        public CalculateBorrowingHandler(
            BorrowingCalculator calculator,
            IBorrowingRepository repo)
        {
            _calculator = calculator;
            _repo = repo;
        }

        public async Task<decimal> Handle(
            CalculateBorrowingCommand request,
            CancellationToken cancellationToken)
        {
            var amount = _calculator.Calculate(request.CreditScore);

            var assessment = new BorrowingAssessment(
                request.CustomerId,
                request.CreditScore,
                amount);

            await _repo.AddAsync(assessment);

            return amount;
        }
    }
}
