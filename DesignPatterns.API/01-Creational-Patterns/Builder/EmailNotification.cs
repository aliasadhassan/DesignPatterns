namespace DesignPatterns.API._01_Creational_Patterns.Builder
{
    public class EmailNotification
    {
        public string To { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public List<string> Attachments { get; set; } = new();
        public bool IsHtml { get; set; }
    }
}
