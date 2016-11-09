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
    public class AssetsController : BaseController
    {
        //
        // GET: /OMS/Assets/
        private IRepository<Assets> repo;

        public ActionResult Index()
        {
            repo = new Repository<Assets>(UnitOfWork);
            return View(repo.GetAll().ToList());
        }
	}
}