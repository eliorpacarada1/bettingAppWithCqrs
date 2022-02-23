using BettingSite2.Dtos.Responses;
using MediatR;

namespace BettingSite2.Handlers.Queries
{
    public class GetAllBetsQuery : IRequest<List<BetReadResponse>>
    {
       
    }
}
