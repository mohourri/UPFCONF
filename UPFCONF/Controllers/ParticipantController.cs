using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPFCONF.Models;

namespace UPFCONF.Controllers
{
    public class ParticipantController : Controller
    {
        // GET: Congres
        public ActionResult Index()
        {
            using (upfconEntities db = new upfconEntities())
            {
                return View(db.Participants.ToList());

            }
        }

        // GET: Congres/Details/5
        public ActionResult Details(int id)
        {
            using (upfconEntities db = new upfconEntities())
            {
                return View(db.Participants.Where(c => c.ID_Participant == id).FirstOrDefault());


            }
        }

        // GET: Congres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Congres/Create
        [HttpPost]
        public ActionResult Create(Participant c)
        {
            try
            {
                using (upfconEntities db = new upfconEntities())
                {
                    db.Participants.Add(c);
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
                return View(db.Participants.Where(x => x.ID_Participant == id).FirstOrDefault());

            }
        }

        // POST: Congres/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Participant c)
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

        // GET: Congres/Delete/5
        public ActionResult Delete(int id)
        {
            using (upfconEntities db = new upfconEntities())
            {
                return View(db.Participants.Where(x => x.ID_Participant == id).FirstOrDefault());

            }
        }

        // POST: Congres/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Participant c)
        {
            try
            {
                using (upfconEntities db = new upfconEntities())
                {
                    c = db.Participants.Where(x => x.ID_Participant == id).FirstOrDefault();
                    db.Participants.Remove(c);
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
