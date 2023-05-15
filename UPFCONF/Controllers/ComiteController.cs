using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPFCONF.Models;

namespace UPFCONF.Controllers
{
    public class ComiteController : Controller
    {
        // GET: Congres
        public ActionResult Index()
        {
            using (upfconEntities db = new upfconEntities())
            {
                var comites = db.Comites.Include(c => c.Congre).ToList();

                return View(comites);

            }
        }

        // GET: Congres/Details/5
        public ActionResult Details(int id)
        {
            using (upfconEntities db = new upfconEntities())
            {
                return View(db.Comites.Where(c => c.ID_Comite == id).FirstOrDefault());


            }
        }

        // GET: Congres/Create
        public ActionResult Create()
        {
            using(upfconEntities db = new upfconEntities())
            {
                List<Congre> congressList = db.Congres.ToList();

                ViewBag.CongressList = congressList;
                return View();

            }
        }

        // POST: Congres/Create
        [HttpPost]
        public ActionResult Create(Comite c)
        {
            try
            {
                using (upfconEntities db = new upfconEntities())
                {
                    db.Comites.Add(c);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Congres/Edit/5
        public ActionResult Edit(int id)
        {
            using (upfconEntities db = new upfconEntities())
            {
                List<Congre> congressList = db.Congres.ToList();

                ViewBag.CongressList = congressList;

                var comite = db.Comites.FirstOrDefault(x => x.ID_Comite == id);
                if (comite == null)
                {
                    return HttpNotFound();
                }

                return View(comite);
            }
        }


        // POST: Congres/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Comite c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (upfconEntities db = new upfconEntities())
                    {
                        db.Entry(c).State = EntityState.Modified;
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
            }
            catch
            {
                // Handle the exception
            }

            // Repopulate the ViewBag.CongressList
            using (upfconEntities db = new upfconEntities())
            {
                List<Congre> congressList = db.Congres.ToList();
                ViewBag.CongressList = congressList;
            }

            return View(c);
        }


        // GET: Congres/Delete/5
        public ActionResult Delete(int id)
        {
            using (upfconEntities db = new upfconEntities())
            {
                return View(db.Comites.Where(x => x.ID_Comite == id).FirstOrDefault());

            }
        }

        // POST: Congres/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Comite c)
        {
            try
            {
                using (upfconEntities db = new upfconEntities())
                {
                    c = db.Comites.Where(x => x.ID_Comite == id).FirstOrDefault();
                    db.Comites.Remove(c);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
