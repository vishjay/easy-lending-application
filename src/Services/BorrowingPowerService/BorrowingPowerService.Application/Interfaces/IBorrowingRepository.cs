using BorrowingPowerService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorrowingPowerService.Application.Interfaces
{
    public interface IBorrowingRepository
    {
        Task AddAsync(BorrowingAssessment assessment);
    }
}
