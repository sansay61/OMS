using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class LimCounterpartyTypeController : BaseController
    {

        private Repository<Limcounterpartytype> limRepo;
        private Repository<Subjecttypes> subjtypesRepo;
        private void InitRepos(bool initChildren = false, bool copyChildrenViewbag = true)
        {
            limRepo = new Repository<Limcounterpartytype>(UnitOfWork);

            if (initChildren)
            {
                subjtypesRepo = new Repository<Subjecttypes>(UnitOfWork);
                if (copyChildrenViewbag)
                    ViewBag.subjecttypes = new SelectList(subjtypesRepo.GetAll().ToList(), "Id", "Description");
            }
        }
        public ActionResult Index()
        {
            InitRepos();
            return View(limRepo.GetAll().ToList());
        }

       
        //
        // GET: /OMS/LimCounterparty/Create
        public ActionResult Create()
        {
            InitRepos(true);
            return View();
        }

        //
        // POST: /OMS/LimCounterparty/Create
        [HttpPost]
        public ActionResult Create(Limcounterpartytype model)
        {
            try
            {
                // TODO: Add insert logic here
                InitRepos(true, false);
                model.Subjecttypes = subjtypesRepo.GetById(model.SubjecttypeId);
                limRepo.Create(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OMS/LimCounterparty/Edit/5
        public ActionResult Edit(int id)
        {
            InitRepos(true);
            var model=limRepo.GetById(id);
            model.SubjecttypeId = model.Subjecttypes.Id;
            return View(model);
        }

        //
        // POST: /OMS/LimCounterparty/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Limcounterpartytype model)
        {
            try
            {
                InitRepos(true, false);
                model.Subjecttypes = subjtypesRepo.GetById(model.SubjecttypeId);
                limRepo.Update(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //
        // GET: /OMS/LimCounterparty/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        //
        // GET: /OMS/LimCounterparty/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /OMS/LimCounterparty/Delete/5
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