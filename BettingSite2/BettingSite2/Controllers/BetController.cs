using BettingSite2.Dtos.Requests;
using BettingSite2.Dtos.Responses;
using BettingSite2.Interfaces;
using BettingSite2.Services;
using Microsoft.AspNetCore.Mvc;

namespace BettingSite2.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BetController : ControllerBase
    {
        private readonly IBetService _services;

        public BetController(IBetService services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<ActionResult<List<BetReadResponse>>> GetAllBets()
        {
            var lista = await _services.GetAllBets();
            return Ok(lista);
        }
        [HttpPost]
        public async Task<ActionResult<BetReadResponse>> CreateBet([FromBody] BetCreateRequest request)
        {
            var betCreated = await _services.CreateBet(request);
            return Ok(betCreated);
        }
    }
}
