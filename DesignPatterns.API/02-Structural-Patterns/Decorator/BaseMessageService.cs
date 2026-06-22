namespace DesignPatterns.API._02_Structural_Patterns.Decorator
{
    public class BaseMessageService :IMessageService
    {
        public string Send(string message)
        {
            return $"Core message sent: '{message}'";
        }
    }
}
