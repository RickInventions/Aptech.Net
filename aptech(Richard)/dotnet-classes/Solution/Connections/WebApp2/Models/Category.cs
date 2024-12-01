using System.ComponentModel.DataAnnotations;

namespace WebApp2.Models
{
    public class Category
    {
        [Key]
        public int id {  get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
