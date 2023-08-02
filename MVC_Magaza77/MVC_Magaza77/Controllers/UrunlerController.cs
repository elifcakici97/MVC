using MVC_Magaza77.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Magaza77.Controllers
{
    public class UrunlerController : Controller
    {
        Model1Container db=new Model1Container();
        // GET: Urunler
        public ActionResult Index()
        {
            return View(db.UrunlerSet.ToList());
        }
        public ActionResult Kaydetme()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kaydetme(Urunler urunler)
        {
            db.UrunlerSet.Add(urunler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Duzenleme(int id)
        {
            var duzenle = db.UrunlerSet.Where(x => x.UrunID == id).FirstOrDefault();
            return View(duzenle);
        }

        [HttpPost]
        public ActionResult Duzenleme(Urunler urunler, int id)
        {
            db.UrunlerSet.AddOrUpdate(urunler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Silme(int id)
        {
            var sil = db.UrunlerSet.Where(x => x.UrunID == id).FirstOrDefault();
            db.UrunlerSet.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        // GET: Urunler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Urunler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Urunler/Create
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

        // GET: Urunler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Urunler/Edit/5
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

        // GET: Urunler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Urunler/Delete/5
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
