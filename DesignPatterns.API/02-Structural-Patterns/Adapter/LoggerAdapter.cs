namespace DesignPatterns.API._02_Structural_Patterns.Adapter
{
    public class LoggerAdapter : ITargetLogger
    {
        private readonly AdvancedLoggerLibrary _advancedLogger;

        public LoggerAdapter()
        {
            _advancedLogger = new AdvancedLoggerLibrary();
        }

        public string LogMessage(string message)
        {
            // Adapter ne purane simple message ko naye advanced format me convert kar diya
            return _advancedLogger.LogAdvanced(message, "Information", DateTime.Now);
        }
    }
}
