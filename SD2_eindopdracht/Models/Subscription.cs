using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SD2_eindopdracht.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int MinAge { get; set; }

        public int? MaxAge { get; set; } //null = no maximum age
        public int? YearlyItems { get; set; } //null = no limit on items

        [Required, Range(0, int.MaxValue)]
        public int LoanPeriod { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int Extensions { get; set; }

        [Required, Range(0, double.MaxValue)]
        public decimal ReservationPrice { get; set; }

        [Required, Range(0, double.MaxValue)]
        public decimal DailyFine { get; set; }

        [Required, Range(0, double.MaxValue)]
        public decimal SubscriptionPrice { get; set; }
        public List<IdentityUser>? Users { get; set; }
    }
}
