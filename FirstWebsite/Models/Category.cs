using System.ComponentModel.DataAnnotations;

namespace FirstWebsite.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
        public int DisplayOrder { get; set; }

    }
}
