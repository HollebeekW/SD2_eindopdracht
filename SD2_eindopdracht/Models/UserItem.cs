using System.ComponentModel.DataAnnotations.Schema;

namespace SD2_eindopdracht.Models
{
    public class UserItem
    {
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; }

        [ForeignKey("Item")]
        public int? ItemId { get; set; }
        public ApplicationUser? User { get; set; }
        public Item? Item { get; set; }
    }
}
