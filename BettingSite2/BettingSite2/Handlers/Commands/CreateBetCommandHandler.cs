using AutoMapper;
using BettingSite2.Dtos.Responses;
using BettingSite2.Interfaces;
using BettingSite2.Model;
using MediatR;

namespace BettingSite2.Handlers.Commands
{
    public class CreateBetCommandHandler : IRequestHandler<CreateBetCommand, BetReadResponse>
    {
        private readonly IBetRepository _repository;
        private readonly IMapper _mapper;

        public CreateBetCommandHandler(IBetRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<BetReadResponse> Handle(CreateBetCommand request, CancellationToken cancellationToken)
        {
            var mappedToBet = _mapper.Map<Bet>(request.model);
            var createdBet = await _repository.CreateBet(mappedToBet);
            var response = _mapper.Map<BetReadResponse>(createdBet);
            return response;
        }
    }
}
