using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeighborhoodSnacks.Models
{
    public class Snacks
    {
        public int SnacksId { get; set; }
        [Required]
        [StringLength(80,MinimumLength = 10, ErrorMessage = "min 10, max 80")]
        [Display(Name = "Snack name")]
        public string SnacksName { get; set;}
        [Required]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "min 10, max 80")]
        [Display(Name = "Snack name")]
        public string SnacksShortDescription { get; set;}
        [Required]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "min 10, max 80")]
        [Display(Name = "Snack name")]
        public string SnacksLongDescription { get;set;}
        [Required]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0,999.999)]
        public decimal SnacksPrice { get; set;}
        [Display(Name = "miniature image url")]
        [StringLength(200)]
        public string ImageUrl { get; set;}
        [Display(Name = "url image thumbnail")]
        public string ImageThumbnailUrl { get; set; }
        [Display(Name = "Favorite? ")]
        public bool IsFavoriteSnack { get; set; }
        [Display(Name = "Stock ")]
        public int Stock { get; set; }
        
        
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
