
using Design_Pattern.Creational.Factory;

namespace Design_Pattern.Creational.Factory_Method
{
    /*We have two types of Users in modicare i.e. Modicare Users & Non Modicare Users
     Modicare Users: Consultant, DP, Citrix_DP
     Non Modicare Users: PC, MyShop, Employee
    */
    public abstract class ModicareUsersTypeFactory
    {
        protected abstract IModicareUsers GetModicareUsers(string userType);

        /*We have option to use this code or not but because of the protected access modifier 
         we use the below code i.e [public IModicareUsers ModicareUsersType(string userType)]
        because we cannot access protected in other class because protected is called only in child class.
        */
        public IModicareUsers ModicareUsersType(string userType)
        {
            IModicareUsers modicareUsers = GetModicareUsers(userType);
            //modicareUsers.calculateDiscountRate();
            return modicareUsers;
        }
    }

    public class ModicareUsers : ModicareUsersTypeFactory
    {
        protected override IModicareUsers GetModicareUsers(string userType)
        {
            IModicareUsers modicareUsers = null;
            switch (userType.ToLower())
            {
                case ("consultant"):
                    return new Consultant();
                case ("dp"):
                    return new DistributerPoint();
                case ("citrix"):
                    return new CitrixDP();
                default:
                    return modicareUsers;
            }
        }
    }
    public class NonModicareUsers : ModicareUsersTypeFactory
    {
        protected override IModicareUsers GetModicareUsers(string userType)
        {
            IModicareUsers nonModicareUsers = null;
            switch (userType.ToLower())
            {
                case ("pc"):
                    return new PrefferedCustomer();
                case ("employee"):
                    return new Employee();
                case ("myshop"):
                    return new MyShop();
                default:
                    return nonModicareUsers;
            }
        }
    }
}

/*
using Design_Pattern.Creational.Factory;
using Design_Pattern.Creational.Factory_Method;

ModicareUsersTypeFactory modicareUsersTypeFactory = new ModicareUsers();
IModicareUsers modicareUsers = modicareUsersTypeFactory.ModicareUsersType("dp");
decimal discount = 0;
discount = modicareUsers != null ? modicareUsers.calculateDiscountRate() : 0;
Console.WriteLine($"Discount: {discount}%");

ModicareUsersTypeFactory nonModicareUsersTypeFactory = new NonModicareUsers();
IModicareUsers nonModicareUsers = nonModicareUsersTypeFactory.ModicareUsersType("employee");
decimal discount1 = 0;
discount1 = nonModicareUsers != null ? nonModicareUsers.calculateDiscountRate() : 0;
Console.WriteLine($"Discount: {discount1}%");
 */
