namespace DesignPatterns.API._01_Creational_Patterns.Builder
{
    public interface IEmailBuilder
    {
        IEmailBuilder SetRecipient(string to);
        IEmailBuilder SetSubject(string subject);
        IEmailBuilder SetBody(string body, bool isHtml);
        IEmailBuilder AddAttachment(string fileName);
        EmailNotification Build();
    }
}
