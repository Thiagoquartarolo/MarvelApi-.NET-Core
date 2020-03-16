using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarvelApi.Domain.Models
{
    public class Characters
    {
        [Key]
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Modified { get; set; }
        public string ResourceURI { get; set; }
        public string Thumbnail { get; set; }

        public List<Comics> ComicList { get; set; }
        public List<Stories> StoryList { get; set; }
        public List<Events> EventList { get; set; }
        public List<Series> SeriesList { get; set; }
        public List<Urls> Urls { get; set; }
    }
}
