using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Domain.Models
{
    public class SeriesSummary
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Series")]
        public int SerieId { get; set; }
        public string ResourceURI { get; set; }
        public string Name { get; set; }

        public Series Series { get; set; }
    }
}
