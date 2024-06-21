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