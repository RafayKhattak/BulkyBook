// Importing necessary namespaces for data annotations
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Namespace for the Category model
namespace BulkyBookWeb.Models
{
    // Class representing the Category model
    public class Category
    {
        // Primary key property for the category
        [Key]
        public int Id { get; set; }

        // Required property for the category name
        [Required]
        public string Name { get; set; }

        // DisplayOrder property for the category with range validation
        [DisplayName("Display Order")] // Display name for UI purposes
        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100")] // Range validation
        public int DisplayOrder { get; set; }

        // Property for storing the creation date and time, with a default value of the current date and time
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
