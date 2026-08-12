namespace EventBus.Abstractions
{
    public interface  IEventBus<T> where T : class
    {
        public Task Publish(T message);
    }
}
