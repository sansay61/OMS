using System;
using System.Collections.Generic;
using QuickFixProcessor.Interfaces;
using System.Linq;
using System.Web;
using QuickFix;


namespace QuickFixProcessor
{
    public class FixApp : MessageCracker, IApplication
    {


        public void FromApp(Message msg, SessionID sessionID)
        {
            Crack(msg, sessionID);
        }
        public void OnCreate(SessionID sessionID) { }
        public void OnLogout(SessionID sessionID) { }
        public void OnLogon(SessionID sessionID) { }
        public void FromAdmin(Message msg, SessionID sessionID) 
        {
        }
        public void ToAdmin(Message msg, SessionID sessionID) { }
        public void ToApp(Message msg, SessionID sessionID) { }

        public void OnMessage(QuickFix.FIX44.AllocationInstruction msg, SessionID sessionID)
        {

        }


        //BBG RFQ/ER/FX AND DEPO ONLY
        public void OnMessage(QuickFix.FIX44.ExecutionReport msg, SessionID sessionID)
        {

        }
        //BBG VCON/TCR/SECURITY ONLY
        public void OnMessage(QuickFix.FIX44.TradeCaptureReport msg, SessionID sessionID)
        {

        }
    }
}