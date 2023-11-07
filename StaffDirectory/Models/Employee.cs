using SQLite;

namespace StaffDirectory.Models
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int EmployeeID { get; set; }
        public string Name  { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; } 
        public string AddressState { get; set; }
        public string AddressZIP { get; set; }
        public string AddressCountry { get ; set; }

    }
}
