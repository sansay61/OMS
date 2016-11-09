using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.UoF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class CurrenciesController : BaseController
    {
        private IRepository<Currencies> repo;
        //
        // GET: /OMS/Currencies/
        public ActionResult Index()
        {
            repo = new Repository<Currencies>(UnitOfWork);
            return View(repo.GetAll().ToList());
        }

        //
       
        //
        // GET: /OMS/Currencies/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OMS/Currencies/Create
        [HttpPost]
        public ActionResult Create(Currencies model)
        {
            try
            {
                repo = new Repository<Currencies>(UnitOfWork);
                repo.Create(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OMS/Currencies/Edit/5
        public ActionResult Edit(int id)
        {
            repo = new Repository<Currencies>(UnitOfWork);
            return View(repo.GetById(id));
        }

        //
        // POST: /OMS/Currencies/Edit/5
        [HttpPost]
        public ActionResult Edit(Currencies item)
        {
            try
            {
                repo = new Repository<Currencies>(UnitOfWork);
                repo.Update(item);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
