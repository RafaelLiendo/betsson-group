using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetssonGroup.Data;
using BetssonGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BetssonGroup.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private BetssonGroupDbContext _db;
        public MoviesController(BetssonGroupDbContext db)
        {
            _db = db;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return _db.Movies
                .Include(m => m.MovieGenres)
                    .ThenInclude(m => m.Genre)
                .ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Movie GetMovieById(int id)
        {
            return _db.Movies
                .Include(m => m.MovieGenres)
                    .ThenInclude(m => m.Genre)
                .FirstOrDefault(m => m.Id == id);
        }
    }
}
