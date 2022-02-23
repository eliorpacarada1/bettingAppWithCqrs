using AutoMapper;
using BettingSite2.Dtos.Requests;
using BettingSite2.Dtos.Responses;
using BettingSite2.Model;

namespace BettingSite2.Profiles
{
    public class BetProfiles : Profile
    {
        public BetProfiles()
        {
            CreateMap<Bet, BetReadResponse>().ReverseMap();
            CreateMap<Bet, BetCreateRequest>().ReverseMap();
            CreateMap<Bet, BetUpdateRequest>().ReverseMap();
            CreateMap<Bet, BetCreateResponse>().ReverseMap();
            CreateMap<Bet, BetUpdateResponse>().ReverseMap();  
        }
    }
}
