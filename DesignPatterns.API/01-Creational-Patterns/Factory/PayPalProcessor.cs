namespace DesignPatterns.API._01_Creational_Patterns.Factory
{
    public class PayPalProcessor : IPaymentProcessor
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Rs. {amount} successfully processed via PayPal Gateway.";
        }
    {
    }
}
