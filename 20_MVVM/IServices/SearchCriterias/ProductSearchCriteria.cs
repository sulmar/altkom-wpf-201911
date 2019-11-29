using Altkom.Shop.Models;

namespace IServices
{
    public abstract class BaseSearchCriteria : Base
    {
    }

    public class ProductSearchCriteria  : BaseSearchCriteria
    {
        public string Color { get; set; }
        public decimal? From { get; set; }
        public decimal? To { get; set; }

      
    }
}
