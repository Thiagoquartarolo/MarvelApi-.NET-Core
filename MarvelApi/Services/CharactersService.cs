using System.Collections.Generic;
using System.Threading.Tasks;
using MarvelApi.Domain.Models;
using MarvelApi.Domain.Repositories;
using MarvelApi.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarvelApi.Services
{
    public class CharactersService : ICharactersService
    {
        private readonly ICharactersRepository _charactersRepository;

        public CharactersService(ICharactersRepository charactersRepository)
        {
            _charactersRepository = charactersRepository;
        }

        public async Task<List<Characters>> ListAsync()
        {
            return await _charactersRepository.ListAsync();
        }

        public async Task<Characters> GetByCharacterId(int characterId)
        {
            return await _charactersRepository.GetByCharacterId(characterId);
        }

        public async Task<List<Comics>> GetComicsByCharacterId(int characterId)
        {
            return await _charactersRepository.GetComicsByCharacterId(characterId);
        }

        public async Task<List<Events>> GetEventsByCharacterId(int characterId)
        {
            return await _charactersRepository.GetEventsByCharacterId(characterId);
        }

        public async Task<List<Series>> GetSeriesByCharacterId(int characterId)
        {
            return await _charactersRepository.GetSeriesByCharacterId(characterId);
        }

        public async Task<List<Stories>> GetStoriesByCharacterId(int characterId)
        {
            return await _charactersRepository.GetStoriesByCharacterId(characterId);
        }
    }
}