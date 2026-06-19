namespace DesignPatterns.API._01_Creational_Patterns.Factory
{
    public class StripeProcessor : IPaymentProcessor
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Rs. {amount} successfully processed via Stripe Gateway.";
        }
    }
}
