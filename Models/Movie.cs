using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetssonGroup.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public float Rate { get; set; }
        public string Length { get; set; }
        public string Img { get; set; }
    }
}
