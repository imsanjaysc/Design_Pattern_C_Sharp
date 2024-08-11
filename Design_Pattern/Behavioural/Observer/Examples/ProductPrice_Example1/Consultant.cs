

namespace Design_Pattern.Behavioural.Observer.Examples.ProductPrice
{
    // Concrete Observer: Consultant
    public class Consultant : IConsultant
    {
        public string ConsultantName { get; private set; }
        public Consultant(string name)
        {
            ConsultantName = name;
        }
        public void Notify(Product product)
        {
            Console.WriteLine($"{ConsultantName}, the price of {product.ProductName} has changed to ${product.Price}!");
        }
    }
}
