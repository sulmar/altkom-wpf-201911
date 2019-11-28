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
                firstName = value;
                OnPropertyChanged();
               // OnPropertyChanged(nameof(FullName));
            }
        }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string City { get; set; }
        public string Photo { get; set; }
        public bool IsRemoved { get; set; }

    }
}
