namespace DesignPatterns.API._02_Structural_Patterns.Decorator
{
    // Concrete Decorator 1: Adds Logging behaviour
    public class LoggingMessageDecorator : MessageDecorator
    {
        public LoggingMessageDecorator(IMessageService innerService) : base(innerService) { }

        public override string Send(string message)
        {
            string logText = $"[LOG]: Initiating transfer at {DateTime.UtcNow} UTC. ";
            return logText + base.Send(message);
        }
    }

    // Concrete Decorator 2: Adds Encryption behaviour
    public class EncryptedMessageDecorator : MessageDecorator
    {
        public EncryptedMessageDecorator(IMessageService innerService) : base(innerService) { }

        public override string Send(string message)
        {
            string encryptedData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(message));
            return base.Send($"ENCRYPTED({encryptedData})");
        }
    }
}
