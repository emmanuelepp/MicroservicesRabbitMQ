namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public string MessageType { get; protected set; }

        protected Event()
        {
            MessageType = GetType().Name;
        }
    }
}

