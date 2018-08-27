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
    public class AutocompleteMoviesController : Controller
    {
        private BetssonGroupDbContext _db;
        public AutocompleteMoviesController(BetssonGroupDbContext db)
        {
            _db = db;
        }

        // GET api/<controller>/deadpool
        [HttpGet("{search}")]
        public IEnumerable<AutocompleteMovie> GetAutocomplete(string search)
        {
            var normalizedSearch = search.ToLower();
            return _db.Movies
                .Where(m =>
                    m.Name.ToLower().Contains(normalizedSearch) ||
                    m.Description.ToLower().Contains(normalizedSearch))
                .Take(5)
                .Select(m => new AutocompleteMovie
                {
                    Id = m.Id,
                    Name = m.Name
                })
                .ToList();
        }

        public class AutocompleteMovie
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}

