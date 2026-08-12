using Microsoft.EntityFrameworkCore;

namespace Persistence.BaseDbContext;

public abstract class BaseDbContext : DbContext
{
    protected BaseDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public override async Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default)
    {
        // Add auditing, domain events dispatching, etc.
        return await base.SaveChangesAsync(cancellationToken);
    }
}
