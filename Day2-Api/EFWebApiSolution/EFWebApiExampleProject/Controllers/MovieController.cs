using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFWebApiExampleProject.Models;

namespace EFWebApiExampleProject.Controllers
{
    public class MovieController : ApiController
    {
        dbMovieShopEntities entities = new dbMovieShopEntities();
        // GET: api/Movie
        [HttpGet]
        public IEnumerable<tblMovie> AllMovies()
        {
            return entities.tblMovies;   
        }

        // GET: api/Movie/5
        public proc_GetMovie_Result Get( [FromUri]int id)
        {
            proc_GetMovie_Result movie = null;
            //movie = entities.tblMovies.ToList().Find(m => m.name == name);
            movie = entities.proc_GetMovie(id).First();
            return movie;
        }

        // POST: api/Movie
        [HttpPost]
        public HttpResponseMessage Something(HttpRequestMessage message,[FromBody]tblMovie movie)
        {
            try
            {
                entities.tblMovies.Add(movie);
                entities.SaveChanges();
                return message.CreateResponse(HttpStatusCode.Accepted, movie);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        // PUT: api/Movie/5
        public HttpResponseMessage Put(HttpRequestMessage message,int id, [FromBody]tblMovie movie)
        {
            try
            {
                entities.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                
                foreach (var item in entities.ChangeTracker.Entries())
                {
                    item.Reload();
                }
                return message.CreateResponse(HttpStatusCode.Accepted, movie);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Movie/5
        public HttpResponseMessage Delete(HttpRequestMessage message, [FromBody]tblMovie movie)
        {
            try
            {
                entities.Entry(movie).State = System.Data.Entity.EntityState.Deleted;
                entities.SaveChanges();
                return message.CreateResponse(HttpStatusCode.Accepted, movie);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
