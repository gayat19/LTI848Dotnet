using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SimpleApiApplication.Models;
using System.Web.Http.Cors;
using System.Web;
using static System.Collections.Specialized.BitVector32;

namespace SimpleApiApplication.Controllers
{
    [EnableCors(origins: "http://localhost:4200",headers:"*",methods:"*")]
    public class MoviesController : ApiController
    {
        private dbMovieShopEntities db = new dbMovieShopEntities();

        // GET: api/Movies
        [Route("api/{mymovies}")]
        public IQueryable<tblMovie> GettblMovies()
        {
            return db.tblMovies;
        }

        // GET: api/Movies/5
        [ResponseType(typeof(tblMovie))]
        public IHttpActionResult GettblMovie(int id)
        {
            tblMovie tblMovie = db.tblMovies.Find(id);
            if (tblMovie == null)
            {
                return NotFound();
            }

            return Ok(tblMovie);
        }

        // PUT: api/Movies/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblMovie(int id, tblMovie tblMovie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblMovie.id)
            {
                return BadRequest();
            }

            db.Entry(tblMovie).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblMovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Movies
        [ResponseType(typeof(tblMovie))]
        public IHttpActionResult PosttblMovie(tblMovie tblMovie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblMovies.Add(tblMovie);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblMovie.id }, tblMovie);
        }

        // DELETE: api/Movies/5
        [ResponseType(typeof(tblMovie))]
        public IHttpActionResult DeletetblMovie(int id)
        {
            tblMovie tblMovie = db.tblMovies.Find(id);
            if (tblMovie == null)
            {
                return NotFound();
            }

            db.tblMovies.Remove(tblMovie);
            db.SaveChanges();

            return Ok(tblMovie);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblMovieExists(int id)
        {
            return db.tblMovies.Count(e => e.id == id) > 0;
        }
    }
}