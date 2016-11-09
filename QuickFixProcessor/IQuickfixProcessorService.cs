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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IQuickfixProcessorService
    {
        [OperationContract]
        void InitiatorStart();
        [OperationContract]
        void Init(string path);
        [OperationContract]
        void InitiatorStop();
        [OperationContract]
        bool isInitiatorStopped();
        [OperationContract]
        bool isInitiatorLoggedOn();
        [OperationContract]
        void TestTCR();
        [OperationContract]
        void TestER();

    }
}