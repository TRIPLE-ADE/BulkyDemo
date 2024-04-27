using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTIme { get; set; } = DateTime.Now; 


    }
}
