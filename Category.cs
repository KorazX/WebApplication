using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class Category
    {
        [Display(Name = "Category name")]
        public string Name { get; set; } = "";
        public int Id { get; set; }
    }
}
