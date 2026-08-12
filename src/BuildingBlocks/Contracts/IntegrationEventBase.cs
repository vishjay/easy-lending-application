namespace Contracts.Events
{
    public abstract record IntegrationEventBase
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public DateTime OccurredOn { get; init; } = DateTime.UtcNow;
    }
}
