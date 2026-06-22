namespace DesignPatterns.API._01_Creational_Patterns.AbstractFactory
{
    public interface IThemeFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
