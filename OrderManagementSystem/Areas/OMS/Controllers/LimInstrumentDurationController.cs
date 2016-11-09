using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class LimInstrumentDurationController : BaseController
    {
        private Repository<Liminstrumentduration> limRepo;
        private Repository<Currencies> currRepo;
        private Repository<Instruments> instrRepo;
        private Repository<Instrumentterms> instrTermRepo;
        private void InitRepos(bool initChildren = false, bool copyChildrenViewbag = true)
        {
            limRepo = new Repository<Liminstrumentduration>(UnitOfWork);

            if (initChildren)
            {
                currRepo = new Repository<Currencies>(UnitOfWork);
                instrRepo = new Repository<Instruments>(UnitOfWork);
                instrTermRepo = new Repository<Instrumentterms>(UnitOfWork);
                if (copyChildrenViewbag)
                {
                    ViewBag.currencies = new SelectList(currRepo.GetAll().ToList(), "Id", "ISO");
                    ViewBag.instruments = new SelectList(instrRepo.GetAll().ToList(), "Id", "Description");
                    ViewBag.instrumentterms = new SelectList(instrTermRepo.GetAll().ToList(), "Id", "Description");
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
        public ActionResult Create(Liminstrumentduration model)
        {
            try
            {
                // TODO: Add insert logic here
                InitRepos(true, false);
                model.Currencies = currRepo.GetById(model.CurrencyId);
                model.Instruments = instrRepo.GetById(model.InstrumentId);
                model.Instrumentterms = instrTermRepo.GetById(model.InstrumentTermId);
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
        public ActionResult Edit(int id, Liminstrumentduration model)
        {
            try
            {
                InitRepos(true, false);
                model.Currencies = currRepo.GetById(model.CurrencyId);
                model.Instruments = instrRepo.GetById(model.InstrumentId);
                model.Instrumentterms = instrTermRepo.GetById(model.InstrumentTermId);
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
