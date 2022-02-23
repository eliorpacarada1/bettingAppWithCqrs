using AutoMapper;
using BettingSite2.Dtos.Responses;
using BettingSite2.Interfaces;
using MediatR;

namespace BettingSite2.Handlers.Queries
{
    public class GetAllBetsQueryHandler : IRequestHandler<GetAllBetsQuery, List<BetReadResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IBetRepository _repository;

        public GetAllBetsQueryHandler(IBetRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public async Task<List<BetReadResponse>> Handle(GetAllBetsQuery request, CancellationToken cancellationToken)
        {

            var entities = await _repository.GetAllBets();
            return _mapper.Map<List<BetReadResponse>>(entities);
            
        }
    }

}
