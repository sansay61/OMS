using OrderManagementSystem.UoF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;


namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class FxController : BaseController
    {
        //
        // GET: /OMS/Fx/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuyRead([DataSourceRequest]DataSourceRequest request)
        {
            FxRepository fxRepo = new FxRepository(UnitOfWork);
            IEnumerable<OrderManagementSystem.Areas.OMS.Models.Fx> fxs = fxRepo.GetBuy();
            return Json(fxs.ToDataSourceResult(request));
        }
    }
}