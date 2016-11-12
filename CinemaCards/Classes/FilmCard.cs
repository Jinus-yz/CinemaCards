using System;

namespace CinemaCards.Classes
{
    class FilmCard
    {
        public String name { get; private set; }
        public FilmCard(string iName)
        {
            name = iName;
        }
    }
}
