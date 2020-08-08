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
using EFWebApiExampleProject.Models;

namespace EFWebApiExampleProject.Controllers
{
    public class tblMoviesController : ApiController
    {
        private dbMovieShopEntities db = new dbMovieShopEntities();

        // GET: api/tblMovies
        public IQueryable<tblMovie> GettblMovies()
        {
            return db.tblMovies;
        }

        // GET: api/tblMovies/5
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

        // PUT: api/tblMovies/5
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

        // POST: api/tblMovies
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

        // DELETE: api/tblMovies/5
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