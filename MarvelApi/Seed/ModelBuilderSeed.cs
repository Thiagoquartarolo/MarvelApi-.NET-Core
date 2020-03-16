using MarvelApi.Domain.Models;
using MarvelApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Seed
{
    public class ModelBuilderSeed
    {
        private readonly DataContext _context;

        public ModelBuilderSeed(DataContext context)
        {
            _context = context;
        }
        public void AddSeed()
        {
            AddCharacters1();
            AddCharacters2();
            AddCharacters3();

            _context.SaveChanges();
        }

        public void AddCharacters1()
        {
            var character1 = new Characters
            {
                Name = "Thor",
                Description = "Nordic God",
                Modified = "2014-04-29T14:18:17-0400",
                ResourceURI = "http://gateway.marvel.com/v1/public/characters/1",
                Thumbnail = "http://i.annihil.us/u/prod/marvel/i/mg/3/20/5232158de5b16"
            };
            _context.Add(character1);

            var comic1 = new Comics
            {
                CharacterId = 1,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/1/comics"
            };
            _context.Add(comic1);

            var comicSummary1 = new ComicSummary
            {
                ComicId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/comics/1",
                Name = "Avengers (1998) #67"
            };
            _context.Add(comicSummary1);

            var comicSummary2 = new ComicSummary
            {
                ComicId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/comics/2",
                Name = "Avengers Vol. II: Red Zone (Trade Paperback)"
            };
            _context.Add(comicSummary2);

            var story1 = new Stories
            {
                CharacterId = 1,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/1/stories"
            };
            _context.Add(story1);

            var storySummary1 = new StorySummary
            {
                StoryId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/stories/1",
                Name = "Cover #19947",
                Type = "Cover"
            };
            _context.Add(storySummary1);

            var storySummary2 = new StorySummary
            {
                StoryId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/stories/2",
                Name = "The 3-D Man!",
                Type = "interiorStory"
            };
            _context.Add(storySummary2);

            var event1 = new Events
            {
                CharacterId = 1,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/1/events"
            };
            _context.Add(event1);

            var eventSummary1 = new EventSummary
            {
                EventId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/events/1",
                Name = "Secret Invasion"
            };
            _context.Add(eventSummary1);

            var serie1 = new Series
            {
                CharacterId = 1,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/1/series",
            };
            _context.Add(serie1);

            var seriesSummary1 = new SeriesSummary
            {
                SerieId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/series/1",
                Name = "Avengers: The Initiative (2007 - 2010)"
            };
            _context.Add(seriesSummary1);

            var seriesSummary2 = new SeriesSummary
            {
                SerieId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/series/2",
                Name = "Deadpool (1997 - 2002)"
            };
            _context.Add(seriesSummary2);

            var urls1 = new Urls
            {
                CharacterId = 1,
                Type = "detail",
                Url = "http://marvel.com/comics/characters/1017100/a-bomb_has?utm_campaign=apiRef&utm_source=8922ec8609741a0af07f32d7ea9b4c83"
            };
            _context.Add(urls1);

            var urls2 = new Urls
            {
                CharacterId = 1,
                Type = "comiclink",
                Url = "http://marvel.com/comics/characters/1017100/a-bomb_has?utm_campaign=apiRef&utm_source=8922ec8609741a0af07f32d7ea9b4c83"
            };
            _context.Add(urls2);

        }

        public void AddCharacters2()
        {
            var character2 = new Characters
            {
                Name = "Spider-Man",
                Description = "Peter Parker ",
                Modified = "2019-07-29T23:09:55-0500",
                ResourceURI = "http://gateway.marvel.com/v1/public/characters/2",
                Thumbnail = "http://i.annihil.us/u/prod/marvel/i/mg/4/20/523244458489416"
            };
            _context.Add(character2);

            var comic2 = new Comics
            {
                CharacterId = 2,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/2/comics"
            };
            _context.Add(comic2);

            var comicSummary3 = new ComicSummary
            {
                ComicId = 2,
                ResourceURI = "http://gateway.marvel.com/v1/public/comics/3",
                Name = "Avengers (2000) #167"
            };
            _context.Add(comicSummary3);

            var comicSummary4 = new ComicSummary
            {
                ComicId = 2,
                ResourceURI = "http://gateway.marvel.com/v1/public/comics/3",
                Name = "Avengers Infinite War"
            };
            _context.Add(comicSummary4);

            var story2 = new Stories
            {
                CharacterId = 2,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/2/stories"
            };
            _context.Add(story2);

            var storySummary3 = new StorySummary
            {
                StoryId = 2,
                ResourceURI = "http://gateway.marvel.com/v1/public/stories/3",
                Name = "Dark #1",
                Type = "Dark"
            };
            _context.Add(storySummary3);

            var storySummary4 = new StorySummary
            {
                StoryId = 2,
                ResourceURI = "http://gateway.marvel.com/v1/public/stories/4",
                Name = "The Amazing Spider-Man!",
                Type = "interiorStory"
            };
            _context.Add(storySummary4);

            var event2 = new Events
            {
                CharacterId = 2,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/2/events"
            };
            _context.Add(event2);

            var eventSummary2 = new EventSummary
            {
                EventId = 2,
                ResourceURI = "http://gateway.marvel.com/v1/public/events/2",
                Name = "Lunar Home"
            };
            _context.Add(eventSummary2);

            var serie2 = new Series
            {
                CharacterId = 2,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/2/series",
            };
            _context.Add(serie2);

            var seriesSummary3 = new SeriesSummary
            {
                SerieId = 2,
                ResourceURI = "http://gateway.marvel.com/v1/public/series/3",
                Name = "Avengers: The Initiative (2007 - 2010)"
            };
            _context.Add(seriesSummary3);

            var seriesSummary4 = new SeriesSummary
            {
                SerieId = 2,
                ResourceURI = "http://gateway.marvel.com/v1/public/series/4",
                Name = "Spider-Man (1968 - 2010)"
            };
            _context.Add(seriesSummary4);

            var urls3 = new Urls
            {
                CharacterId = 2,
                Type = "detail",
                Url = "http://marvel.com/comics/characters/10585/Ref&utm_source=8922ec8609741a0af07f32d7ea9b4c83"
            };
            _context.Add(urls3);

            var urls4 = new Urls
            {
                CharacterId = 2,
                Type = "comiclink",
                Url = "http://marvel.com/comics/characters/10585/Ref&utm_source=8922ec8609741a0af07f32d7ea9b4c83"
            };
            _context.Add(urls4);

        }

        public void AddCharacters3()
        {
            var character3 = new Characters
            {
                Name = "Iron-Man",
                Description = "Tony Stark",
                Modified = "2010-03-03T12:21:45-0500",
                ResourceURI = "http://gateway.marvel.com/v1/public/characters/3",
                Thumbnail = "http://i.annihil.us/u/prod/marvel/i/mg/3/12/5232434489416"
            };
            _context.Add(character3);

            var comic3 = new Comics
            {
                CharacterId = 3,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/3/comics"
            };
            _context.Add(comic3);

            var comicSummary5 = new ComicSummary
            {
                ComicId = 3,
                ResourceURI = "http://gateway.marvel.com/v1/public/comics/5",
                Name = "Avengers Initiative (1986) #1"
            };
            _context.Add(comicSummary5);

            var comicSummary6 = new ComicSummary
            {
                ComicId = 3,
                ResourceURI = "http://gateway.marvel.com/v1/public/comics/6",
                Name = "War Machine"
            };
            _context.Add(comicSummary6);

            var story3 = new Stories
            {
                CharacterId = 3,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/3/stories"
            };
            _context.Add(story3);

            var storySummary5 = new StorySummary
            {
                StoryId = 3,
                ResourceURI = "http://gateway.marvel.com/v1/public/stories/5",
                Name = "Tha's my future",
                Type = "Fiction"
            };
            _context.Add(storySummary5);

            var storySummary6 = new StorySummary
            {
                StoryId = 3,
                ResourceURI = "http://gateway.marvel.com/v1/public/stories/6",
                Name = "The Ultrajant Iron-Man",
                Type = "Apocalipse Story"
            };
            _context.Add(storySummary6);

            var event3 = new Events
            {
                CharacterId = 3,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/3/events"
            };
            _context.Add(event3);

            var eventSummary3 = new EventSummary
            {
                EventId = 3,
                ResourceURI = "http://gateway.marvel.com/v1/public/events/3",
                Name = "The Iron-Man"
            };
            _context.Add(eventSummary3);

            var serie3 = new Series
            {
                CharacterId = 3,
                Available = 1,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/3/series",
            };
            _context.Add(serie3);

            var seriesSummary5 = new SeriesSummary
            {
                SerieId = 3,
                ResourceURI = "http://gateway.marvel.com/v1/public/series/5",
                Name = "Avengers: Infinity War"
            };
            _context.Add(seriesSummary5);

            var seriesSummary6 = new SeriesSummary
            {
                SerieId = 3,
                ResourceURI = "http://gateway.marvel.com/v1/public/series/6",
                Name = "Iron-Man (2000 - 2010)"
            };
            _context.Add(seriesSummary6);

            var urls5 = new Urls
            {
                CharacterId = 3,
                Type = "detail",
                Url = "http://marvel.com/comics/characters/101225/Ref&utm_source=8922ec8604d45854dd7f32d7ea9b4c83"
            };
            _context.Add(urls5);

            var urls6 = new Urls
            {
                CharacterId = 3,
                Type = "comiclink",
                Url = "http://marvel.com/comics/characters/101225/Ref&utm_source=8922ecgt848hya0af07f32d7ea9b4c83"
            };
            _context.Add(urls6);

        }

    }
}