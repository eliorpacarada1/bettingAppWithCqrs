using BettingSite2.Model;

namespace BettingSite2.Interfaces
{
    public interface IBetRepository
    {
        Task<List<Bet>> GetAllBets();
        Task<Bet> GetBetById(Guid id);
        Task<Bet> CreateBet(Bet bet);
        Task<Bet> UpdateBet(Bet bet);
        Task<bool> DeleteBet(Bet bet);
    }
}
