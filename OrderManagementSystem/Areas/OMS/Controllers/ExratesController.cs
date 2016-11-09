using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.UoF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class ExratesController : BaseController
    {
        //
        // GET: /OMS/Assets/
        private IRepository<Exrates> repo;

        public ActionResult Index()
        {
            repo = new Repository<Exrates>(UnitOfWork);
            return View(repo.GetAll().ToList());
        }

        //
        // GET: /OMS/Exrates/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /OMS/Exrates/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OMS/Exrates/Create
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

        //
        // GET: /OMS/Exrates/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /OMS/Exrates/Edit/5
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

        //
        // GET: /OMS/Exrates/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /OMS/Exrates/Delete/5
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
