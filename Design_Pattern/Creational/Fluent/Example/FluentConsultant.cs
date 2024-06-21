
namespace Design_Pattern.Creational.Fluent.Example
{
    public class FluentConsultant
    {
        private Consultant _consultant = new Consultant();

        public FluentConsultant ConsultantName (string fullName) { 
            _consultant.Name = fullName;
            return this;
        }
        public FluentConsultant ConsultantEmail(string email)
        {
            _consultant.Email = email;
            return this;
        }
        public FluentConsultant ConsultantMobile(string mobile)
        {
            _consultant.Mobile= mobile;
            return this;
        }
        public FluentConsultant ConsultantValidTitle(string valid_t)
        {
            _consultant.ValidTitle = valid_t;
            return this;
        }
        public FluentConsultant ConsultantPaidTitle(string pai_t)
        {
            _consultant.PaidTitle = pai_t;
            return this;
        }
        public FluentConsultant NewUplines(long upline)
        {
            _consultant.NewUplines.Add(upline);
            return this;
        }
        public FluentConsultant ConsultantOrders(string order_no, decimal order_value)
        {
            _consultant.OrderHistory[order_no] = order_value;
            return this;
        }
        public void BuildProfile()
        {
            Console.WriteLine($"Name: {_consultant.Name}, \nMobile: {_consultant.Mobile}, \nEmail: {_consultant.Email}");
        }
    }
}
