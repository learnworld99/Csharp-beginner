using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCshap3.Film
{
    internal class Film
    {
        public string Title { get; set; }
        public string Sutradara { get; set; }
        public decimal Budget { get; set; }
        public double Rating { get; set; }

        public Film(string title,
            string sutradara, 
            decimal budget,
            double rating)
        {
            this.Title = title;
            this.Sutradara = sutradara;
            this.Budget = budget;
            this.Rating = rating;
        }
    }
}
