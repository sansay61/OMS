using QuickFixProcessor;
using OrderManagementSystem.UoF;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.Administration;
using System.Web.Hosting;
using OrderManagementSystem.Areas.OMS.Models;
using System.Globalization;

namespace OrderManagementSystem.Areas.OMS.Controllers
{

    public class HomeController : BaseController
    {
        //
        // GET: /OMS/Home/
        public ActionResult Index()
        {
           // ParseTCR();
            //Resend();
            //CleanAppPool();
            return View();
        }

        private void CleanAppPool()
        {
            using (ServerManager iisManager=new ServerManager())
            {
                SiteCollection sites = iisManager.Sites;
                foreach(Site site in sites)
                {
                    if (site.Name==HostingEnvironment.ApplicationHost.GetSiteName())
                    {
                        iisManager.ApplicationPools[site.Applications["/"].ApplicationPoolName].Recycle();
                        break;
                    }
                }
            }
        }
        public void Resend()
        {
            QuickFix.FIX44.ResendRequest msg = new QuickFix.FIX44.ResendRequest(new QuickFix.Fields.BeginSeqNo(12), new QuickFix.Fields.EndSeqNo(950));
            msg.Header.SetField(new QuickFix.Fields.TargetCompID("BLPUAT_STP"));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID("NBKRMULTI_UAT"));
            QuickFix.Session.SendToTarget(msg);

        }

        
    }
}