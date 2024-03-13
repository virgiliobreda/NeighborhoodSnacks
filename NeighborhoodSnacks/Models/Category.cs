using System.ComponentModel.DataAnnotations;

namespace NeighborhoodSnacks.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [StringLength(100, ErrorMessage = "Max lengh is 100")]
        [Required(ErrorMessage = "Set name")]
        [Display(Name = "Name")]
        public string CategoryName { get; set; }
        [StringLength(100, ErrorMessage = "Max lengh is 100")]
        [Required(ErrorMessage = "Set description")]
        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }

        public List<Snacks> Snacks { get; set; }

    }
}
