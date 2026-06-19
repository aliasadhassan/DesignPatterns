namespace DesignPatterns.API._01_Creational_Patterns.Prototype
{
    public class Product : IProductPrototype
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public List<string> Features { get; set; } = new();

        // Constructor jo real app me DB se data load hone jaisa cost lagata hai
        public Product(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        // Prototype Clone Method
        public IProductPrototype Clone()
        {
            // 1. Shallow Copy: Basic data types (string, int, decimal) ko copy karega
            var clonedProduct = (Product)this.MemberwiseClone();

            // 2. Deep Copy: Taake list alag ho jaye aur dono objects ek dusre ka data kharab na karein
            clonedProduct.Features = new List<string>(this.Features);

            return clonedProduct;
        }
    }
}
