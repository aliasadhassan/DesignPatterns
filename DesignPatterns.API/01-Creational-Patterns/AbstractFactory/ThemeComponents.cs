namespace DesignPatterns.API._01_Creational_Patterns.AbstractFactory
{
    public class ThemeComponents
    {
        // Concrete Products for Light Theme
        public class LightButton : IButton
        {
            public string Render() => "Rendering a sleek White Button with blue text.";
        }

        public class LightTextBox : ITextBox
        {
            public string Display() => "Displaying a Borderless Light Textbox.";
        }

        // Concrete Products for Dark Theme
        public class DarkButton : IButton
        {
            public string Render() => "Rendering a Dark Charcoal Button with white text.";
        }

        public class DarkTextBox : ITextBox
        {
            public string Display() => "Displaying a Neon-bordered Dark Textbox.";
        }
    }
}
