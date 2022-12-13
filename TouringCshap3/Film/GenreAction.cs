using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCshap3.Film
{
    internal class GenreAction : Film
    {
        public List<string> Actors { get; set; } = null;
        public string Genre { get; set; }
        public const string format = "{0}{1,20}{2,20}{3,20}{4,20}{5,20}";

        public GenreAction(string title,
            string sutradara, 
            decimal budget, 
            double rating,
            string genre,
            List<string> actor) : base(title, sutradara, budget, rating)
        {
            this.Genre = genre;
            this.Actors = actor;
        }

        public void GetFilm()
        {
            int w_screen = Console.WindowWidth / 2;

            Console.WriteLine( this.Title.ToUpper().PadLeft(w_screen));
            Console.WriteLine(format, "title", "sutradara", "budget", "rating", "genre", "actors");
            
            Console.WriteLine(format, this.Title.ToLower(), this.Sutradara, this.Budget, this.Rating, this.Genre, string.Join(", ", this.Actors ));
        }
    }
}
