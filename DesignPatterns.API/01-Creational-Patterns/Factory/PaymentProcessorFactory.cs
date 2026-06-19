namespace DesignPatterns.API._01_Creational_Patterns.Factory
{
    public static class PaymentProcessorFactory
    {
        public static IPaymentProcessor CreateProcessor(string methodType)
        {
            return methodType.ToLower() switch
            {
                "stripe" => new StripeProcessor(),
                "paypal" => new PayPalProcessor(),
                _ => throw new ArgumentException("Invalid payment method selected!")
            };
        }
    }
}
