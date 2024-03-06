using Microsoft.EntityFrameworkCore;

namespace Domain.Enteties
{
    public class Pass
    {
        public Guid PassId { get; set; }
        public DateOnly DateOfСreation { get; set; }
        public DateOnly ExpiryDate { get; set; }

        public Guid AccessLevelId { get; set; }
        public Guid EmployeeId { get; set; }

        public AccessLevel AccessLevel { get; set; }
        public Employee Employee { get; set; }

        public ICollection<Report> Reports { get; set; }

        public Pass(DateOnly dateOfСreation, DateOnly expiryDate, Guid accessLevelId, Guid employeeId)
        {
            PassId = Guid.NewGuid();
            DateOfСreation = dateOfСreation;
            ExpiryDate = expiryDate;
            AccessLevelId = accessLevelId;
            EmployeeId = employeeId;

            Reports = new List<Report>();
        }

    }
}
