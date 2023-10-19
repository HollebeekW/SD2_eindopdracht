using System.ComponentModel.DataAnnotations;

namespace SD2_eindopdracht.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public List<Item>? Items { get; set; }
    }
}
