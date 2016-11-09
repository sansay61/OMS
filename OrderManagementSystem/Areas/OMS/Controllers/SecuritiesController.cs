using Kendo.Mvc.UI;
using OrderManagementSystem.UoF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class SecuritiesController : BaseController
    {
        //
        // GET: /OMS/Securities/
        public ActionResult BuyIndex()
        {
            return View();
        }
        public ActionResult SellIndex()
        {
            return View();
        }

        //
        // GET: /OMS/Securities/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult BuyRead([DataSourceRequest]DataSourceRequest request)
        {
            SecurityRepository secsRepo = new SecurityRepository(UnitOfWork);
            IEnumerable<OrderManagementSystem.Areas.OMS.Models.Security> secs = secsRepo.GetBuy();
            return Json(secs.ToDataSourceResult(request));
        }

        public ActionResult SellRead([DataSourceRequest]DataSourceRequest request)
        {
            SecurityRepository secsRepo = new SecurityRepository(UnitOfWork);
            IEnumerable<OrderManagementSystem.Areas.OMS.Models.Security> secs = secsRepo.GetSell();
            return Json(secs.ToDataSourceResult(request));
        }
    }
}
