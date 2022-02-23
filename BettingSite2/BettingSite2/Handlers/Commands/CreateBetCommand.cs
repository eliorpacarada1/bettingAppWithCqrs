using BettingSite2.Dtos.Requests;
using BettingSite2.Dtos.Responses;
using MediatR;

namespace BettingSite2.Handlers.Commands
{
    public class CreateBetCommand : IRequest<BetReadResponse>
    {
        public BetCreateRequest model;

        public CreateBetCommand(BetCreateRequest model)
        {
            this.model = model;
        }
    }
}
