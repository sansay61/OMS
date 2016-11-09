using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using QuickFix;
using QuickFix.Transport;
using QuickFix.FIX44;
using OrderManagementSystem.etc;
using System.Web.Helpers;
using System.Security.Claims;
using OrderManagementSystem.QuickfixProcessorService;

namespace OrderManagementSystem
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalVariables.sessionSettings = new SessionSettings(Server.MapPath("~") + "App_Data\\fix.cfg");
            //IApplication fixapp=new FIX.FixApp();
            //IMessageStoreFactory storeFactory = new FileStoreFactory(GlobalVariables.sessionSettings);
            //FileLogFactory logFactory = new FileLogFactory(GlobalVariables.sessionSettings);
            //GlobalVariables.initiator = new SocketInitiator(fixapp, storeFactory, GlobalVariables.sessionSettings, logFactory);
            //Using WCF instead
            GlobalVariables.proxy = new QuickfixProcessorServiceClient();
            GlobalVariables.proxy.Init(Server.MapPath("~") + "App_Data\\fix.cfg");

            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
        }

        protected void CurrentDomain_DomainUnload(object sender, EventArgs e)
        {
            
            if (GlobalVariables.proxy != null)
                GlobalVariables.proxy.Close();
            throw new Exception("domain unloaded");

        }
    }
}
