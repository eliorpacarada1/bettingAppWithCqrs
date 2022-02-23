using BettingSite2.Dtos.Requests;
using BettingSite2.Dtos.Responses;

namespace BettingSite2.Interfaces
{
    public interface IBetService
    {
        Task<List<BetReadResponse>> GetAllBets();
        Task<BetReadResponse> CreateBet(BetCreateRequest request);
    }
}
