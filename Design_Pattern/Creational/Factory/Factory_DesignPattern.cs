
namespace Design_Pattern.Creational.Factory
{
    public interface IModicareUsers
    {
        decimal calculateDiscountRate();
        //bool validateUserIdentity();
        //Order createOrder();
    }

    public class Consultant : IModicareUsers
    {
        public decimal calculateDiscountRate()
        {
            return 20;
        }
    }
    public class DistributerPoint : IModicareUsers
    {
        public decimal calculateDiscountRate()
        {
            return 30;
        }
    }
    public class CitrixDP : IModicareUsers
    {
        public decimal calculateDiscountRate()
        {
            return 7;
        }
    }
    public class Employee : IModicareUsers
    {
        public decimal calculateDiscountRate()
        {
            return 50;
        }
    }
    public class MyShop : IModicareUsers
    {
        public decimal calculateDiscountRate()
        {
            return 15;
        }
    }
    public class PrefferedCustomer : IModicareUsers
    {
        public decimal calculateDiscountRate()
        {
            return 10;
        }
    }

    public class Order
    {
        public long OrderId { get; set; }
    }

    /*Note: We can also implement abstract class intead of interface 
     E.g.: I wanted to share my thoughts on the factory pattern and interface segregation principle. ]
    I think that in some cases, it may not be necessary to define an interface and let a class implement 
    the definition.

   In order to achieve this scenario, our factory should not be an interface. 
    Instead, we can replace it with an abstract class and let the derived class choose whether 
    it needs to implement the GetAccountDetails() method specific to client needs. 
    Other classes may ignore this method if it has been defined as abstract in the base class.

   This way, we can achieve the factory pattern without the need for interface segregation 
    principle for just one method. I believe this approach can simplify our code and make it more flexible.

    virtual vs override
    --------------------------
     */
    //public abstract class ModicareUsers
    //{
    //    public abstract decimal calculateDiscountRate();
    //    public virtual bool validateUserIdentity()
    //    {
    //        return true;
    //    }
    //    public abstract Order createOrder();
    //}

    //public class Consultant : ModicareUsers
    //{
    //    public override decimal calculateDiscountRate()
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public override bool validateUserIdentity()
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public override Order createOrder()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
