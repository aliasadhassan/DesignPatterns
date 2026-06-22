namespace DesignPatterns.API._02_Structural_Patterns.Decorator
{
    public abstract class MessageDecorator :IMessageService
    {
        protected readonly IMessageService _innerService;
        protected MessageDecorator(IMessageService innerService)
        {
            _innerService = innerService;
        }

        public virtual string Send(string message)
        {
            return _innerService.Send(message);
        }
    }
}
