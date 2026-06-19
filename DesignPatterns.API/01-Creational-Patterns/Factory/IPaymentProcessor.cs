namespace DesignPatterns.API._01_Creational_Patterns.Factory
{
    public interface IPaymentProcessor
    {
        string ProcessPayment(decimal amount);
    }
}
