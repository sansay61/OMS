using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.UoF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class Subj2RatingsController : BaseController
    {
        private Repository<Subj2ratings> subj2RatingsRepo;
        private Repository<Ratings> ratingsRepo;
        private Repository<Subjects> subjectsRepo;
        
        public void initRepos()
        {
            subj2RatingsRepo = new Repository<Subj2ratings>(UnitOfWork);
            ratingsRepo = new Repository<Ratings>(UnitOfWork);
            subjectsRepo = new Repository<Subjects>(UnitOfWork);
        }
       
        public ActionResult Index()
        {
            subj2RatingsRepo = new Repository<Subj2ratings>(UnitOfWork);
            return View(subj2RatingsRepo.GetAll().ToList());
        }

        //
        // GET: /OMS/Subj2Ratings/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        //
        // GET: /OMS/Subj2Ratings/Create
        public ActionResult Create()
        {
            ratingsRepo = new Repository<Ratings>(UnitOfWork);
            subjectsRepo = new Repository<Subjects>(UnitOfWork);
            ViewBag.subjects = (subjectsRepo).GetAll().ToList();
            ViewBag.ratings = (ratingsRepo).GetAll().ToList();
            return View();
        }

        //
        // POST: /OMS/Subj2Ratings/Create
        [HttpPost]
        public ActionResult Create(Subj2ratings model)
        {
            try
            {
                subj2RatingsRepo = new Repository<Subj2ratings>(UnitOfWork);
                ratingsRepo = new Repository<Ratings>(UnitOfWork);
                subjectsRepo = new Repository<Subjects>(UnitOfWork);
                model.Ratings = ratingsRepo.GetById(model.RatingId);
                model.Subjects = subjectsRepo.GetById(model.SubjectId);
                subj2RatingsRepo.Create(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OMS/Subj2Ratings/Edit/5
        public ActionResult Edit(int id)
        {
            subj2RatingsRepo = new Repository<Subj2ratings>(UnitOfWork);
            ratingsRepo = new Repository<Ratings>(UnitOfWork);
            subjectsRepo = new Repository<Subjects>(UnitOfWork);
            ViewBag.ratings = ratingsRepo.GetAll().ToList();
            ViewBag.subject = subjectsRepo.GetAll().ToList();
            return View(subj2RatingsRepo.GetById(id));
        }

        //
        // POST: /OMS/Subj2Ratings/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Subj2ratings model)
        {
            try
            {
                subj2RatingsRepo = new Repository<Subj2ratings>(UnitOfWork);
                ratingsRepo = new Repository<Ratings>(UnitOfWork);
                subjectsRepo = new Repository<Subjects>(UnitOfWork);
                model.Ratings = ratingsRepo.GetById(model.RatingId);
                model.Subjects = subjectsRepo.GetById(model.SubjectId);
                subj2RatingsRepo.Update(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OMS/Subj2Ratings/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /OMS/Subj2Ratings/Delete/5
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
