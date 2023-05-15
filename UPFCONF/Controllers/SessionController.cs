using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPFCONF.Models;

namespace UPFCONF.Controllers
{
    public class SessionController : Controller
    {


        // GET: Session
        public ActionResult Index()
        {
            using (upfconEntities db = new upfconEntities())
            {
                var sessions = db.Sessions.Include(c => c.Congre).ToList();

                return View(sessions);

            }
        }

        // GET: Session/Details/5
        public ActionResult Details(int id)
        {
            using (upfconEntities db = new upfconEntities())
            {
                return View(db.Sessions.Where(c => c.ID_Session == id).FirstOrDefault());


            }
        }

        // GET: Session/Create
        public ActionResult Create()
        {
            using(upfconEntities db = new upfconEntities())
            {

                List<Congre> congressList = db.Congres.ToList();

                ViewBag.CongressList = congressList;
                return View();
            }
        }

        // POST: Session/Create
        [HttpPost]
        public ActionResult Create(Session c)
        {
            try
            {
                using (upfconEntities db = new upfconEntities())
                {
                    db.Sessions.Add(c);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Session/Edit/5
        public ActionResult Edit(int id)
        {
            using (upfconEntities db = new upfconEntities())
            {
                return View(db.Sessions.Where(x => x.ID_Session == id).FirstOrDefault());

            }
        }

        // POST: Session/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Session c)
        {
            try
            {
                using (upfconEntities db = new upfconEntities())
                {
                    db.Entry(c).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }


            }
            catch
            {
                return View();
            }
        }

        // GET: Session/Delete/5
        public ActionResult Delete(int id)
        {
            using (upfconEntities db = new upfconEntities())
            {
                return View(db.Sessions.Where(x => x.ID_Session == id).FirstOrDefault());

            }
        }

        // POST: Session/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Session c)
        {
            try
            {
                using (upfconEntities db = new upfconEntities())
                {
                    c = db.Sessions.Where(x => x.ID_Session == id).FirstOrDefault();
                    db.Sessions.Remove(c);
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
