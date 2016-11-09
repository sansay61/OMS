using OrderManagementSystem.QuickfixProcessorService;
using QuickFix;
using QuickFix.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystem.etc
{
    public static class GlobalVariables
    {
        public static SocketInitiator initiator { get; set; }
        public static SessionSettings sessionSettings { get; set; }

        public static QuickfixProcessorServiceClient proxy { get; set; }
    }
}