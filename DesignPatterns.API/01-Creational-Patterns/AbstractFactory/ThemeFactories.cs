using static DesignPatterns.API._01_Creational_Patterns.AbstractFactory.ThemeComponents;

namespace DesignPatterns.API._01_Creational_Patterns.AbstractFactory
{
    public class ThemeFactories
    {
        public class LightThemeFactory : IThemeFactory
        {
            public IButton CreateButton() => new LightButton();
            public ITextBox CreateTextBox() => new LightTextBox();
        }

        public class DarkThemeFactory : IThemeFactory
        {
            public IButton CreateButton() => new DarkButton();
            public ITextBox CreateTextBox() => new DarkTextBox();
        }
    }
}
