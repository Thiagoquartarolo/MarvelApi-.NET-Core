﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Domain.Models
{
    public class Stories
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Characters")]
        public int CharacterId { get; set; }
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionURI { get; set; }
        public List<StorySummary> StorySummary { get; set; }

        public Characters Characters { get; set; }
    }
}
