namespace DesignPatterns.API._01_Creational_Patterns.Builder
{
    public class EmailBuilder:IEmailBuilder
    {
        private EmailNotification _email = new();

        public IEmailBuilder SetRecipient(string to)
        {
            _email.To = to;
            return this;
        }

        public IEmailBuilder SetSubject(string subject)
        {
            _email.Subject = subject;
            return this;
        }

        public IEmailBuilder SetBody(string body, bool isHtml)
        {
            _email.Body = body;
            _email.IsHtml = isHtml;
            return this;
        }

        public IEmailBuilder AddAttachment(string fileName)
        {
            _email.Attachments.Add(fileName);
            return this;
        }

        public EmailNotification Build()
        {
            // Reset object for next use and return current build
            var completedEmail = _email;
            _email = new EmailNotification();
            return completedEmail;
        }
    }
}
