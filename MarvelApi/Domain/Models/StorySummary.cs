using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Domain.Models
{
    public class StorySummary
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Stories")]
        public int StoryId { get; set; }
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Stories Stories { get; set; }
    }
}
