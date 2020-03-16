using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarvelApi.Domain.Models;
using MarvelApi.Domain.Services;

namespace MarvelApi.Controllers
{
    [ApiController]
    [Route("/v1/public/characters")]
    public class CharactersController : Controller
    {
        private readonly ICharactersService _charactersService;

        public CharactersController(ICharactersService charactersService)
        {
            _charactersService = charactersService;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<Characters>> Get()
        {
            return await _charactersService.ListAsync();
        }

        [HttpGet]
        [Route("{characterId:int}")]
        public async Task<Characters> GetByCharacterId(int characterId)
        {
            return await _charactersService.GetByCharacterId(characterId);
        }

        [HttpGet]
        [Route("{characterId:int}/comics")]
        public async Task<List<Comics>> GetComicsByCharacterId(int characterId)
        {
            return await _charactersService.GetComicsByCharacterId(characterId);
        }

        [HttpGet]
        [Route("{characterId:int}/events")]
        public async Task<List<Events>> GetEventsByCharacterId(int characterId)
        {
            return await _charactersService.GetEventsByCharacterId(characterId);
        }

        [HttpGet]
        [Route("{characterId:int}/series")]
        public async Task<List<Series>> GetSeriesByCharacterId(int characterId)
        {
            return await _charactersService.GetSeriesByCharacterId(characterId);
        }

        [HttpGet]
        [Route("{characterId:int}/stories")]
        public async Task<List<Stories>> GetStoriesByCharacterId(int characterId)
        {
            return await _charactersService.GetStoriesByCharacterId(characterId);
        }

    }
}