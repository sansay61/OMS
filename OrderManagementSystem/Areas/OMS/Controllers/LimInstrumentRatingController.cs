using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class LimInstrumentRatingController : BaseController
    {
        private Repository<Liminstrumentrating> limRepo;
        private Repository<Subjecttypes> subjtypesRepo;
        private Repository<Instruments> instrRepo;
        private Repository<Ratings> ratingsRepo;
        private void InitRepos(bool initChildren = false, bool copyChildrenViewbag = true)
        {
            limRepo = new Repository<Liminstrumentrating>(UnitOfWork);

            if (initChildren)
            {
                subjtypesRepo = new Repository<Subjecttypes>(UnitOfWork);
                instrRepo = new Repository<Instruments>(UnitOfWork);
                ratingsRepo = new Repository<Ratings>(UnitOfWork);
                if (copyChildrenViewbag)
                {
                    ViewBag.subjecttypes = new SelectList(subjtypesRepo.GetAll().ToList(), "Id", "Description");
                    ViewBag.instruments = new SelectList(instrRepo.GetAll().ToList(), "Id", "Description");
                    ViewBag.ratings = new SelectList(ratingsRepo.GetAll().ToList(), "Id", "Snp");
                }
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
        public ActionResult Create(Liminstrumentrating model)
        {
            try
            {
                // TODO: Add insert logic here
                InitRepos(true, false);
                model.Subjecttypes = subjtypesRepo.GetById(model.SubjectTypeId);
                model.Ratings = ratingsRepo.GetById(model.RatingId);
                model.Instruments = instrRepo.GetById(model.InstrumentId);
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
            return View(limRepo.GetById(id));
        }

        //
        // POST: /OMS/LimCounterparty/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Liminstrumentrating model)
        {
            try
            {
                InitRepos(true, false);
                model.Subjecttypes = subjtypesRepo.GetById(model.SubjectTypeId);
                model.Ratings = ratingsRepo.GetById(model.RatingId);
                model.Instruments = instrRepo.GetById(model.InstrumentId);
                limRepo.Update(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
