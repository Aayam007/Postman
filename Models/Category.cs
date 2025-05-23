using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HunterLordAPI.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "The category name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The category description is required")]
        [StringLength(500)]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }
    }

    public class CreateCategoryRequest
    {
        [Required(ErrorMessage = "The category name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The category description is required")]
        [StringLength(500)]
        public string Description { get; set; }
    }

    public class UpdateCategoryRequest
    {
        [Required(ErrorMessage = "The category name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The category description is required")]
        [StringLength(500)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
} 