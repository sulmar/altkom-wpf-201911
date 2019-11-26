namespace Altkom.Shop.Models
{
    public class Employee : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string HashPassword { get; set; }
    }
}
