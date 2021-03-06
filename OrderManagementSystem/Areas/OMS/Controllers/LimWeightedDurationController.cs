﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class LimWeightedDurationController : BaseController
    {
        private Repository<Limweightedduration> limRepo;
        private Repository<Instruments> instrRepo;
        private void InitRepos(bool initChildren = false, bool copyChildrenViewbag = true)
        {
            limRepo = new Repository<Limweightedduration>(UnitOfWork);

            if (initChildren)
            {
                instrRepo = new Repository<Instruments>(UnitOfWork);
                if (copyChildrenViewbag)
                {
                    ViewBag.instruments = new SelectList(instrRepo.GetAll().ToList(), "Id", "Description");
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
        public ActionResult Create(Limweightedduration model)
        {
            try
            {
                // TODO: Add insert logic here
                InitRepos(true, false);
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
        public ActionResult Edit(int id, Limweightedduration model)
        {
            try
            {
                InitRepos(true, false);
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
