namespace DesignPatterns.API._02_Structural_Patterns.Adapter
{
    public interface ITargetLogger
    {
        // Purana tareeqa jo simple message leta hai
        string LogMessage(string message);
    }
}
