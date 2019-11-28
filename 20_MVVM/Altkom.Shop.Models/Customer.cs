namespace Altkom.Shop.Models
{
    public class Customer : BaseEntity
    {
        private string firstName;

        public string FirstName
        {
            get => firstName; 
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged();
                }
            }
        }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string City { get; set; }
        public string Photo { get; set; }
        public bool IsRemoved { get; set; }

    }
}
