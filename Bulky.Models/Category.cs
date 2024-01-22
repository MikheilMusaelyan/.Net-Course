using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Display Namee")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 109, ErrorMessage = "Error!!!!!!")]
        public string DisplayOrder { get; set; }
    }
}
