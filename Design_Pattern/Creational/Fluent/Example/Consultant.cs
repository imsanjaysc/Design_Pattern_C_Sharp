
namespace Design_Pattern.Creational.Fluent.Example
{
    //Scenario:
    /*
     There is an Page in Admin panel from which admin can enter mcano and we have to give the business 
     and basic info of consultant of that mcano according to the month selected
     */
    public class Consultant
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Mobile { get; set; } = default!;
        public string ValidTitle { get; set; } = default!;
        public string PaidTitle { get; set; } = default!;
        public List<long> NewUplines { get; private set; } = new List<long>();
        public Dictionary<string, decimal> OrderHistory { get; private set; } = new Dictionary<string, decimal>();
    }

}


/*
Program.cs
----------------
 
using Design_Pattern.Creational.Fluent.Example;

FluentConsultant fluentConsultant = new FluentConsultant();


fluentConsultant
    .ConsultantName("Sanjay Singh Chouahn")
    .ConsultantEmail("sschouhan@gmail.com")
    .ConsultantMobile("7896754321")
    .ConsultantPaidTitle("Director")
    .ConsultantValidTitle("Diamond Director")
    .NewUplines(11000000)
    .NewUplines(11000234)
    .NewUplines(71007090)
    .NewUplines(71007980)
    .ConsultantOrders("VBA6543", 7000)
    .ConsultantOrders("VT67854", 9000)
    .ConsultantOrders("VIH5545", 140000)
    .ConsultantOrders("VUR5466", 35000)
    .BuildProfile();
 */