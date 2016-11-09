using OrderManagementSystem.etc;
using QuickFix;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagementSystem.Areas.OMS.Controllers
{
    public class FIXController : Controller
    {
        const string defaultfixcfg=
             "  [DEFAULT] \n"+
             "   ConnectionType=initiator \n"+
             "   ReconnectInterval=2 \n"+
             "   FileStorePath=store \n"+
             "   FileLogPath=log \n"+
             "   StartTime=00:00:00 \n"+
             "   EndTime=00:00:00 \n"+
             "   SocketConnectHost=205.216.112.15 \n"+
             "   SocketConnectPort=21339 \n"+
             "   LogoutTimeout=5 \n"+
             "   UseDataDictionary=Y \n"+
             "   DataDictionary=blp_dict.xml \n"+
             "    [SESSION] \n"+
             "    BeginString=FIX.4.4 \n"+
             "    SenderCompID=NBKRMULTI_UAT \n"+
             "    TargetCompID=BLPUAT_STP \n"+
             "    HeartBtInt=30";

        [HttpGet]
        public ActionResult Settings()
        {
            string path = Server.MapPath("~")+"App_Data\\fix.cfg";
            string model;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    model = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                model = defaultfixcfg;
            }

            return View(model: model);
        }

        [HttpPost]
        public ActionResult Settings(string cfg)
        {
            string path = Server.MapPath("~") + "App_Data\\fix.cfg";
            try
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                    sr.Write(cfg);
                    sr.Close();
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }

            return View(model: cfg);
        }

        [HttpGet]
        public ActionResult Managing()
        {

            return View(model: getInitiatorStatus());
        }

        
        [HttpPost]
        public ActionResult Managing(string action)
        {
            switch (action)
            {
                    
                case "Start":
                    if (GlobalVariables.proxy.isInitiatorStopped()) etc.GlobalVariables.proxy.InitiatorStart();
                    break;
                case "Restart":
                    if (!GlobalVariables.proxy.isInitiatorStopped())
                    {
                        GlobalVariables.proxy.InitiatorStop();
                        GlobalVariables.proxy.InitiatorStart();
                    }
                    break;
                case "Stop":
                    if (!GlobalVariables.proxy.isInitiatorStopped()) etc.GlobalVariables.proxy.InitiatorStop();
                    break;
                case "TestTCR":
                    if (!GlobalVariables.proxy.isInitiatorStopped())
                        GlobalVariables.proxy.TestTCR();
                    break;
                case "TestER":
                    if (!GlobalVariables.proxy.isInitiatorStopped())
                        GlobalVariables.proxy.TestER();
                    break;
                default: break;
            }
            return View(model: getInitiatorStatus());
        }
        private string getInitiatorStatus()
        {
            string status="";
            status = "Is loggedon=" + GlobalVariables.proxy.isInitiatorLoggedOn().ToString() + "\n";
            status += "Is started=" + (!GlobalVariables.proxy.isInitiatorStopped()).ToString() + " \n";
            return status;
        }

       
        public ActionResult Logging()
        {
            string logpath=GlobalVariables.sessionSettings.Get().GetString(SessionSettings.FILE_LOG_PATH);
            HashSet<SessionID> sessions= GlobalVariables.sessionSettings.GetSessions();
            if (sessions.Count!=1) return null;
            SessionID session=sessions.First();
            string filePrefix = FileLog.Prefix(session);
            string date = DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd");
            string eventFilePath = System.IO.Path.Combine(logpath, date+"."+filePrefix + ".event.log");
            string messageFilePath = System.IO.Path.Combine(logpath, date + "." + filePrefix + ".messages.log");
            try
            {
                using (FileStream sr = new FileStream(eventFilePath,FileMode.OpenOrCreate,FileAccess.Read,FileShare.ReadWrite))
                {
                    using (TextReader tr=new StreamReader(sr))
                    {
                        ViewData["events"] = tr.ReadToEnd();
                        sr.Close();
                    }
                }
                using (FileStream sr = new FileStream(messageFilePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (TextReader tr = new StreamReader(sr))
                    {
                        ViewData["messages"] = tr.ReadToEnd();
                        sr.Close();
                    }
                }
            }
            catch (Exception e)
            {
                return View("Error");
            }

            return View();
        }
        
        

        
       
	}
}