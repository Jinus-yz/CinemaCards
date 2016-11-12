using System;
using System.Data.Linq.Mapping;

namespace CinemaCards.Classes
{
    [Table(Name="films")]
    class FilmTable
    {
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }

        [Column]
        public String name { get; set; }

        [Column]
        public DateTime viewed { get; set; }

        [Column]
        public DateTime added { get; set; }
    }
}
