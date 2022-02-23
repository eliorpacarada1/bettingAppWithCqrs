using System.ComponentModel.DataAnnotations;

namespace BettingSite2.Model
{
    public class Bet
    {
        [Key]
        public Guid ID { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }

        public DateTime? IsUpdated { get; set; }

        public DateTime CreatedOnDate { get; set; } = DateTime.UtcNow;


    }
}
