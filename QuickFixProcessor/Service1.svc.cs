using QuickFix;
using QuickFix.Transport;
using System;
using System.Collections.Generic;using QuickFixProcessor.Interfaces;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace QuickFixProcessor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class Service1 : IQuickfixProcessorService
    {
        public SocketInitiator initiator { get; set; }
        public SessionSettings sessionSettings { get; set; }
        public void InitiatorStart()
        {
            initiator.Start();
        }

        public void Init(string path)
        {
            sessionSettings = new SessionSettings(path);
            IApplication fixapp = new FixApp();
            IMessageStoreFactory storeFactory = new FileStoreFactory(sessionSettings);
            FileLogFactory logFactory = new FileLogFactory(sessionSettings);
            initiator = new SocketInitiator(fixapp, storeFactory, sessionSettings, logFactory);
        }

        public void InitiatorStop()
        {
            initiator.Stop();
        }

        public bool isInitiatorStopped()
        {
            return initiator.IsStopped;
        }

        public bool isInitiatorLoggedOn()
        {
            return initiator.IsLoggedOn;
        }

        public void TestTCR()
        {
            Logic.Processor.InsertTCR();
        }

        public void TestER()
        {
            Logic.Processor.InsertER();
        }
    }
}
