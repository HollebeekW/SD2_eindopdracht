using Microsoft.AspNetCore.Identity;

namespace SD2_eindopdracht.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
    }
}
