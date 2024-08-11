
namespace Design_Pattern.Behavioural.Observer.Examples.ProductPrice
{
    // Observer Interface
    public interface IConsultant
    {
        void Notify(Product product);
    }
}
/*
 Program.cs File
-------------------------
using Design_Pattern.Behavioural.Observer.Examples.ProductPrice;

Product riceBrainOil = new Product("Rice Brain oil", 1500.00);
Consultant Pranaya = new Consultant("Pranaya");
Consultant Priyanka = new Consultant("Priyanka");
Consultant Rout = new Consultant("Rout");

//Add Consultant
riceBrainOil.AddConsultant(Pranaya);   // Pranaya wants to watch the price of the Samsung Mobile
riceBrainOil.AddConsultant(Priyanka);  // Priyanka wants to watch the price of the Samsung Mobile
riceBrainOil.AddConsultant(Rout);      // Rout also wants to watch the price of the Samsung Mobile

//RemoveConsultant
riceBrainOil.RemoveConsultants(Priyanka);

// Simulating a price change
riceBrainOil.Price = 1200.00;
Console.ReadKey();
 */