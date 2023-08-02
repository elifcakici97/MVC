using MVC_Magaza77.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Magaza77.Controllers
{
    public class YetkililerController : Controller
    {
        Model1Container db=new Model1Container();
        // GET: Yetkililer
        public ActionResult Index()
        {
            return View(db.YetkililerSet.ToList());
        }
        public ActionResult Kaydetme()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydetme(Yetkililer yetkililer)
        {
            db.YetkililerSet.Add(yetkililer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Duzenleme(int id)
        {
            var duzenle=db.YetkililerSet.Where(x=>x.YetkiliID==id).FirstOrDefault();
            return View(duzenle);
        }

        [HttpPost]
        public ActionResult Duzenleme(Yetkililer yetkililer,int id)
        {
            db.YetkililerSet.AddOrUpdate(yetkililer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Silme(int id)
        {
            var sil=db.YetkililerSet.Where(x=>x.YetkiliID==id).FirstOrDefault();
            db.YetkililerSet.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }





        // GET: Yetkililer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Yetkililer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yetkililer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Yetkililer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Yetkililer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Yetkililer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Yetkililer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
