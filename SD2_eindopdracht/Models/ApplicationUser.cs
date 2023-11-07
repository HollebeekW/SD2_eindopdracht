using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SD2_eindopdracht.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int? SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
        public List<Item>? Items { get; set; }

        [Range(0, int.MaxValue)]
        public int Age { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Fine { get; set; }

        public bool IsBlocked { get; set; }
    }
}
