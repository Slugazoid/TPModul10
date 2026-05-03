using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TP_MODUL10_103022400122;

namespace TP_MODUL10_103022400122_Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private static readonly List<Film> _filmList = new List<Film>
        {
            new Film("Inception", "Christopher Nolan", "2010", "Sci-Fi", "9.0"),
            new Film("Interstellar", "Christopher Nolan", "2014", "Sci-Fi", "8.7"),
            new Film("Parasite", "Bong Joon-ho", "2019", "Thriller", "8.6")
        };

        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return _filmList;
        }

        [HttpGet("{id}")]
        public Film Get(int id)
        {
            return _filmList[id];
        }

        [HttpPost]
        public void Post([FromBody] Film filmBaru)
        {
            _filmList.Add(filmBaru);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _filmList.RemoveAt(id);
        }
    }

}

