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
    public class GenresController : Controller
    {
        private BetssonGroupDbContext _db;
        public GenresController(BetssonGroupDbContext db)
        {
            _db = db;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Genre> GetAll()
        {
            return _db.Genres
                .ToList();
        }
    }
}
