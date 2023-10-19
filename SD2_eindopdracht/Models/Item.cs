using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required, ForeignKey("Author")]
        public int AuthorId { get; set; }

        [Required, ForeignKey("Category")]

        public int CategoryId { get; set; }
    }
}
