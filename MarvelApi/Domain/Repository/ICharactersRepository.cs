using System.Collections.Generic;
using System.Threading.Tasks;
using MarvelApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelApi.Domain.Repositories
{
    public interface ICharactersRepository
    {
        Task<List<Characters>> ListAsync();
        Task<Characters> GetByCharacterId(int characterId);
        Task<List<Comics>> GetComicsByCharacterId(int characterId);
        Task<List<Events>> GetEventsByCharacterId(int characterId);
        Task<List<Series>> GetSeriesByCharacterId(int characterId);
        Task<List<Stories>> GetStoriesByCharacterId(int characterId);

    }
}