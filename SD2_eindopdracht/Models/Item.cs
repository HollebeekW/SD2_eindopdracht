using System.ComponentModel.DataAnnotations;

namespace SD2_eindopdracht.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required, Range(1,2023, ErrorMessage = "Kies een jaar tussen 1 en 2023")]
        public int YearOfRelease { get; set; }

        [Required]
        public Author Author { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
