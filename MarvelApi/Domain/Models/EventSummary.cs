using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Domain.Models
{
    public class EventSummary
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Events")]
        public int EventId { get; set; }
        public string ResourceURI { get; set; }
        public string Name { get; set; }

        public Events Events { get; set; }
    }
}
