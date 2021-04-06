using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMusicStore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMusicStore.Controllers
{
    [Route("api/[controller]")]
    public class AlbumController : Controller
    {

        private readonly MusicContext _musicContext;


        public AlbumController(MusicContext musicContext)
        {
            _musicContext = musicContext;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return _musicContext.Albums.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Album> Get(long id)
        {
            var album = _musicContext.Albums.Find(id);

            if (album == null)
            {
                return NotFound();
            }

            return album;
        }

        // POST api/values
        [HttpPost]
        public Album Post([FromBody] Album album)
        {
            _musicContext.Add(album);
            _musicContext.SaveChanges();
            return album;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Album Put(long id, [FromBody] Album album)
        {
            _musicContext.Entry(album).State = EntityState.Modified;
            _musicContext.SaveChanges();
            return album;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            var album = _musicContext.Albums.Find(id);
            _musicContext.Remove(album);
        }
    }
}
