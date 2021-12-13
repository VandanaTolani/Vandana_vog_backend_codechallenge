namespace VogCodeChallenge.Service.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public Address MailingAddress { get; set; }
        public long DepartmentId { get; set; }
    }
}
