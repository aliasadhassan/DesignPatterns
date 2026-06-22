namespace DesignPatterns.API._02_Structural_Patterns.Adapter
{
    // Consider kry k kisi company ki advanced class jisko hm direct edit nhi krr skty
    public class AdvancedLoggerLibrary
    {
        public string LogAdvanced(string text, string severity, DateTime timestamp)
        {
            return $"[{timestamp}] [{severity.ToUpper()}]: {text}";
        }
    }
}
