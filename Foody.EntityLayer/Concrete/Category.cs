using System.ComponentModel.DataAnnotations;

namespace Foody.EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }  
        public string CategoryName { get; set; } = string.Empty;
        public bool CategoryStatus { get; set; }
    }
}
