using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SD2_eindopdracht.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int MinAge { get; set; }

        public int? MaxAge { get; set; } //null = no maximum age
        public int? YearlyItems { get; set; } //null = no limit on items

        [Required]
        public int LoanPeriod { get; set; }

        [Required]
        public int Extensions { get; set; }

        [Required]
        public decimal ReservationPrice { get; set; }

        [Required]
        public decimal DailyFine { get; set; }

        [Required]
        public decimal SubscriptionPrice { get; set; }
        public List<IdentityUser>? Users { get; set; }
    }
}
