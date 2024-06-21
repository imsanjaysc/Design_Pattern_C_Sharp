using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational.Fluent
{
    public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee NameOfEmployee(string firstName, string lastName) { 
        employee.FirstName = firstName;
        employee.LastName = lastName;
            return this;
        }
        public FluentEmployee Designation(string designation)
        {
            employee.Designation = designation;
            return this;
        }
        public FluentEmployee WorkingOn(string company)
        {
            employee.WorksFor = company;
            return this;
        }
        public FluentEmployee Born(string dob)
        {
            employee.DateOfBirth = Convert.ToDateTime(dob);
            return this;
        }
        public FluentEmployee StaysAt(string address)
        {
            employee.Address = address;
            return this;
        }
        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, \nDateOfBirth: {employee.DateOfBirth}, Designation: {employee.Designation}, \nDepartment: {employee.WorksFor}, \nAddress: {employee.Address}");
        }
    }
}
