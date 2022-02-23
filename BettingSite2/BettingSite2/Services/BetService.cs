using AutoMapper;
using BettingSite2.Dtos.Requests;
using BettingSite2.Dtos.Responses;
using BettingSite2.Handlers.Commands;
using BettingSite2.Handlers.Queries;
using BettingSite2.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace BettingSite2.Services
{
    public class BetService : IBetService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BetService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public Task<BetReadResponse> CreateBet(BetCreateRequest request)
        {
            var command = new CreateBetCommand(request);

            return _mediator.Send(command);
        }

        public async Task<List<BetReadResponse>> GetAllBets()
        {
            var query = new GetAllBetsQuery();

            var response = await _mediator.Send(query);

            return response;
            
        }
    }
}
