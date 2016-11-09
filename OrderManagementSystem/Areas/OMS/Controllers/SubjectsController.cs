using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagementSystem.UoF;
using OrderManagementSystem.Areas.OMS.Models;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class SubjectsController : BaseController
    {
        //
        // GET: /OMS/Assets/
        private IRepository<Subjects> repo;

        public ActionResult Index()
        {
            repo = new Repository<Subjects>(UnitOfWork);
            return View(repo.GetAll().ToList());
        }

        //
        // GET: /OMS/Subjects/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /OMS/Subjects/Create
        public ActionResult Create()
        {
            ViewBag.statuses = new Repository<Statuses>(UnitOfWork).GetAll().ToList();
            ViewBag.types = new Repository<Subjecttypes>(UnitOfWork).GetAll().ToList();
            return View();
        }

        //
        // POST: /OMS/Subjects/Create
        [HttpPost]
        public ActionResult Create(Subjects model)
        {
            try
            {
                repo = new Repository<Subjects>(UnitOfWork);
                IRepository<Subjecttypes> subjtypesrepo = new Repository<Subjecttypes>(UnitOfWork);
                IRepository<Statuses> statusesrepo = new Repository<Statuses>(UnitOfWork);
                model.Statuses = statusesrepo.GetById(model.StatusId);
                model.Subjecttypes = subjtypesrepo.GetById(model.SubjectTypeId);
                IRepository<Users> usersrepo = new Repository<Users>(UnitOfWork);
                model.User = usersrepo.GetById(1);
                repo.Create(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OMS/Subjects/Edit/5
        public ActionResult Edit(int id)
        {
            repo = new Repository<Subjects>(UnitOfWork);
            Subjects model = repo.GetById(id);
            model.StatusId = model.Statuses.Id;
            model.SubjectTypeId = model.Subjecttypes.Id;
            ViewBag.statuses = new Repository<Statuses>(UnitOfWork).GetAll().ToList();
            ViewBag.types = new Repository<Subjecttypes>(UnitOfWork).GetAll().ToList();
            return View(model);
        }

        //
        // POST: /OMS/Subjects/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,Subjects model)
        {
            try
            {
                repo = new Repository<Subjects>(UnitOfWork);
                IRepository<Subjecttypes> subjtypesrepo = new Repository<Subjecttypes>(UnitOfWork);
                IRepository<Statuses> statusesrepo = new Repository<Statuses>(UnitOfWork);
                model.Statuses = statusesrepo.GetById(model.StatusId);
                model.Subjecttypes = subjtypesrepo.GetById(model.SubjectTypeId);
                IRepository<Users> usersrepo = new Repository<Users>(UnitOfWork);
                model.User = usersrepo.GetById(1);
                repo.Update(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OMS/Subjects/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /OMS/Subjects/Delete/5
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
