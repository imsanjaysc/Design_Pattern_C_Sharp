
namespace ObserverDesignPattern
{
    // The Observer Interface
    public interface IObserver
    {
        // Receive Notification from Subject
        void Update(string availability);
    }
}

/*
 Program.cs File
-----------------------
using ObserverDesignPattern;

Subject calciumComplex = new Subject("Well Calcium Complex", 520, "Out Of Stock");

//User Sanjay will be created and the user1 object will be registered to the subject
Observer user1 = new Observer("Sanjay");
user1.AddSubscriber(calciumComplex);

//User Pranaya will be created and the user1 object will be registered to the subject
Observer user2 = new Observer("Pranaya");
user2.AddSubscriber(calciumComplex);

//User Priyanka will be created and the user3 object will be registered to the subject
Observer user3 = new Observer("Priyanka");
user3.AddSubscriber(calciumComplex);

Console.WriteLine("Well Calcium Complex current state : " + calciumComplex.GetAvailability());
Console.WriteLine();

user3.RemoveSubscriber(calciumComplex);

// Now the product is available
calciumComplex.SetAvailability("Available");
Console.Read();
 */