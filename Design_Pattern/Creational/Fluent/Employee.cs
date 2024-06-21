using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational.Fluent
{
    public class Employee
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Designation { get; set; } = default!;
        public string WorksFor { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } = default!;
    }
}

/*
 Program.cs
-----------------
using Design_Pattern.Creational.Fluent;

FluentEmployee fluentEmployee = new FluentEmployee();
fluentEmployee
    .NameOfEmployee("Sanjay", "Singh")
    .Born("07/08/1990")
    .WorkingOn("Modicare")
    .Designation("Senior Software Developer")
    .StaysAt("Greater Noida")
    .ShowEmployeeInfo();
*/