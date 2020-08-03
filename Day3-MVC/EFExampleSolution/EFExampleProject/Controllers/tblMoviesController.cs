using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EFExampleProject;

namespace EFExampleProject.Controllers
{
    public class tblMoviesController : Controller
    {
        private dbMovieShopEntities db = new dbMovieShopEntities();

        // GET: tblMovies
        public ActionResult Index()
        {
            //List<tblMovie> movies = db.tblMovies.ToList();//select * from tblMovie
            db.Configuration.ProxyCreationEnabled = false;//lazy loading
            List<tblMovie> movies = db.tblMovies.Where((m) => m.tblDiscs.Count > 5).ToList();
            var myMovies = from m in movies where m.duration > 115 select m;
            return View(myMovies);
        }

        // GET: tblMovies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMovie tblMovie = db.tblMovies.Find(id);
            if (tblMovie == null)
            {
                return HttpNotFound();
            }
            return View(tblMovie);
        }

        // GET: tblMovies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblMovies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,duration")] tblMovie tblMovie)
        {
            if (ModelState.IsValid)
            {
                db.tblMovies.Add(tblMovie);//collection's add
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblMovie);
        }

        // GET: tblMovies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMovie tblMovie = db.tblMovies.Find(id);
            if (tblMovie == null)
            {
                return HttpNotFound();
            }
            return View(tblMovie);
        }

        // POST: tblMovies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,duration")] tblMovie tblMovie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblMovie).State = EntityState.Modified;//check if any change is made in the view to the model data
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblMovie);
        }

        // GET: tblMovies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMovie tblMovie = db.tblMovies.Find(id);
            if (tblMovie == null)
            {
                return HttpNotFound();
            }
            return View(tblMovie);
        }

        // POST: tblMovies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
          tblMovie tblMovie = db.tblMovies.Find(id);
            db.tblMovies.Remove(tblMovie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
