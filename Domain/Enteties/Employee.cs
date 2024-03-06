using Microsoft.EntityFrameworkCore;

namespace Domain.Enteties
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string JobTitle { get; set; }
        public string Phonenumber { get; set; }
        public string EmailAddress { get; set; }

        public Pass? Pass { get; set; }


        public Employee(string firstName, string lastName, string middleName, DateOnly dateOfBirth, string jobTitle, string phonenumber, string emailAddress)
        {
            EmployeeId = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
            JobTitle = jobTitle;
            Phonenumber = phonenumber;
            EmailAddress = emailAddress;
        }

    }
}
