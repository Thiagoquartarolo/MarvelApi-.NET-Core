using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MarvelApi.Domain.Models;
using MarvelApi.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MarvelApi.Persistence.Repositories
{
    public class CharactersRepository : BaseRepository, ICharactersRepository
    {
        public CharactersRepository(DataContext context) : base(context)
        { }

        public async Task<List<Characters>> ListAsync()
        {
            var character = await _context.Characters.AsNoTracking()
                .Include(x => x.ComicList)
                    .ThenInclude(x => x.ComicSummary)
                .Include(x => x.StoryList)
                    .ThenInclude(x => x.StorySummary)
                .Include(x => x.EventList)
                    .ThenInclude(x => x.Itens)
                .Include(x => x.SeriesList)
                    .ThenInclude(x => x.Itens)
                .Include(x => x.Urls)
                .ToListAsync();

            return character;
        }

        public async Task<Characters> GetByCharacterId(int characterId)
        {
            return await _context.Characters.AsNoTracking()
                .Include(x => x.ComicList)
                    .ThenInclude(x => x.ComicSummary)
                .Include(x => x.StoryList)
                    .ThenInclude(x => x.StorySummary)
                .Include(x => x.EventList)
                    .ThenInclude(x => x.Itens)
                .Include(x => x.SeriesList)
                    .ThenInclude(x => x.Itens)
                .Include(x => x.Urls)
                .FirstOrDefaultAsync(x => x.CharacterId == characterId);
        }

        public async Task<List<Comics>> GetComicsByCharacterId(int characterId)
        {
            return await _context.Comics.AsNoTracking()
                .Include(x => x.ComicSummary)
                .Where(x => x.CharacterId == characterId)
                .ToListAsync();
        }

        public async Task<List<Events>> GetEventsByCharacterId(int characterId)
        {
            return await _context.Events.AsNoTracking()
                .Include(x => x.Itens)
                .Where(x => x.CharacterId == characterId)
                .ToListAsync();
        }

        public async Task<List<Series>> GetSeriesByCharacterId(int characterId)
        {
            return await _context.Series.AsNoTracking()
                .Include(x => x.Itens)
                .Where(x => x.CharacterId == characterId)
                .ToListAsync();
        }

        public async Task<List<Stories>> GetStoriesByCharacterId(int characterId)
        {
            return await _context.Stories.AsNoTracking()
                .Include(x => x.StorySummary)
                .Where(x => x.CharacterId == characterId)
                .ToListAsync();
        }
    }
}