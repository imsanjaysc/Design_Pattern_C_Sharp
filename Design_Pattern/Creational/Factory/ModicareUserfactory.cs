
namespace Design_Pattern.Creational.Factory
{
    internal class ModicareUserfactory
    {
        public static IModicareUsers GetModicareUsers(string type)
        {
            IModicareUsers modicareUsers = null;
            if (type.ToLower().Equals("consultant"))
            {
                modicareUsers = new Consultant();
            }
            else if (type.ToLower().Equals("dp"))
            {
                modicareUsers = new DistributerPoint();
            }
            else if (type.ToLower().Equals("citrix"))
            {
                modicareUsers = new CitrixDP();
            }
            else if (type.ToLower().Equals("employee"))
            {
                modicareUsers = new Employee();
            }
            else if (type.ToLower().Equals("myshop"))
            {
                modicareUsers = new MyShop();
            }
            else if (type.ToLower().Equals("pc"))
            {
                modicareUsers = new PrefferedCustomer();
            }

            return modicareUsers;
        }
    }
}

/*
 Program.cs Code:


using Design_Pattern.Creational.Factory;

IModicareUsers modicareUsers = null;
modicareUsers = ModicareUserfactory.GetModicareUsers("employee");
decimal discount = modicareUsers.calculateDiscountRate();
Console.WriteLine($"Discount: {discount}%");
 */