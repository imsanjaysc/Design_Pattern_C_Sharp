
namespace Design_Pattern.Behavioural.Observer.Examples.ProductPrice
{
    // Concrete Subject: Product
    public class Product : IProduct
    {
        public List<IConsultant> _consultant = new List<IConsultant>();
        public string ProductName { get; private set; }
        public double _price;
        public double Price
        {
            get { return Price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    NotifyConsultants();
                }
            }
        }
        public Product(string ProductName, double Price)
        {
            this.ProductName = ProductName;
            _price = Price;
        }
        public void AddConsultant(IConsultant consultant)
        {
            _consultant.Add(consultant);
        }
        public void RemoveConsultants(IConsultant consultant)
        {
            _consultant.Remove(consultant);
        }
        public void NotifyConsultants()
        {
            foreach (var item in _consultant)
            {
                item.Notify(this);
            }
        }
    }
}
