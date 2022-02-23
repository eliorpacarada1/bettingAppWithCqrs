using BettingSite2.Model;
using Microsoft.EntityFrameworkCore;

namespace BettingSite2.Data
{
    public class MyWebApiContext : DbContext
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options) : base(options) { }

        public DbSet<Bet> Bets { get; set; }
    }
}
