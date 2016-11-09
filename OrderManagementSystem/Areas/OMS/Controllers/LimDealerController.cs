using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class LimDealerController : BaseController
    {
        private Repository<Limdealer> limRepo;
        private Repository<Currencies> currRepo;
        private Repository<Users> dealersRepo;
        private void InitRepos(bool initChildren = false, bool copyChildrenViewbag = true)
        {
            limRepo = new Repository<Limdealer>(UnitOfWork);

            if (initChildren)
            {
                currRepo = new Repository<Currencies>(UnitOfWork);
                dealersRepo = new Repository<Users>(UnitOfWork);
                if (copyChildrenViewbag)
                {
                    ViewBag.currencies = new SelectList(currRepo.GetAll().ToList(), "Id", "ISO");
                    ViewBag.currencies = new SelectList(dealersRepo.GetAll().ToList(), "Id", "login");
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
        public ActionResult Create(Limdealer model)
        {
            try
            {
                // TODO: Add insert logic here
                InitRepos(true, false);
                model.Currencies = currRepo.GetById(model.CurrencyId);
                model.Dealer = dealersRepo.GetById(model.UserId);
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
        public ActionResult Edit(int id, Limdealer model)
        {
            try
            {
                InitRepos(true, false);
                model.Currencies = currRepo.GetById(model.CurrencyId);
                model.Dealer = dealersRepo.GetById(model.UserId);
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
