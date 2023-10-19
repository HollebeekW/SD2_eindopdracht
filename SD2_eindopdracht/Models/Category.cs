using System.ComponentModel.DataAnnotations;

namespace SD2_eindopdracht.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Item>? Items { get; set; }

    }
}
