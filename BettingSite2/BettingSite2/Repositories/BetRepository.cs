using BettingSite2.Data;
using BettingSite2.Interfaces;
using BettingSite2.Model;
using Microsoft.EntityFrameworkCore;

namespace BettingSite2.Repositories
{
    public class BetRepository : IBetRepository
    {
        private readonly MyWebApiContext _db;

        public BetRepository(MyWebApiContext db)
        {
            _db = db;
        }
        public async Task<Bet> CreateBet(Bet bet)
        {
            await _db.AddAsync(bet);
            await _db.SaveChangesAsync();
            return bet;
        }

        public async Task<bool> DeleteBet(Bet bet)
        {
            _db.Remove(bet);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<List<Bet>> GetAllBets()
        {
           var allBets = await _db.Bets.ToListAsync();
           return allBets;
        }

        public async Task<Bet> GetBetById(Guid id)
        {
            var bet = await _db.Bets.FindAsync(id);
            if (bet != null)
            {
                _db.Entry(bet).State = EntityState.Detached;
                return bet;
            }
            return bet;
        }

        public async Task<Bet> UpdateBet(Bet bet)
        {
            bet.IsUpdated = DateTime.UtcNow;
            _db.Entry(bet).State = EntityState.Modified;
            _db.Update(bet);
            await _db.SaveChangesAsync();
            return bet;
        }
    }
}
