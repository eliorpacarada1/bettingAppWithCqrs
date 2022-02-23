namespace BettingSite2.Dtos.Responses
{
    public class BetReadResponse
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }

        public DateTime? IsUpdated { get; set; }

        public DateTime CreatedOnDate { get; set; } = DateTime.UtcNow;

    }
}
