namespace DesignPatterns.API._01_Creational_Patterns.AbstractFactory
{
    public interface IButton
    {
        string Render();
    }
    // Abstract Product B
    public interface ITextBox
    {
        string Display();
    }
}
