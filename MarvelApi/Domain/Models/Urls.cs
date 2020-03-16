using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Domain.Models
{
    public class Urls
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Characters")]
        public int CharacterId { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }

        public Characters Characters { get; set; }
    }
}
