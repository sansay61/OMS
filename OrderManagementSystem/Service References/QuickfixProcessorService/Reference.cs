﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagementSystem.QuickfixProcessorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuickfixProcessorService.IQuickfixProcessorService")]
    public interface IQuickfixProcessorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/InitiatorStart", ReplyAction="http://tempuri.org/IQuickfixProcessorService/InitiatorStartResponse")]
        void InitiatorStart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/InitiatorStart", ReplyAction="http://tempuri.org/IQuickfixProcessorService/InitiatorStartResponse")]
        System.Threading.Tasks.Task InitiatorStartAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/Init", ReplyAction="http://tempuri.org/IQuickfixProcessorService/InitResponse")]
        void Init(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/Init", ReplyAction="http://tempuri.org/IQuickfixProcessorService/InitResponse")]
        System.Threading.Tasks.Task InitAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/InitiatorStop", ReplyAction="http://tempuri.org/IQuickfixProcessorService/InitiatorStopResponse")]
        void InitiatorStop();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/InitiatorStop", ReplyAction="http://tempuri.org/IQuickfixProcessorService/InitiatorStopResponse")]
        System.Threading.Tasks.Task InitiatorStopAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/isInitiatorStopped", ReplyAction="http://tempuri.org/IQuickfixProcessorService/isInitiatorStoppedResponse")]
        bool isInitiatorStopped();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/isInitiatorStopped", ReplyAction="http://tempuri.org/IQuickfixProcessorService/isInitiatorStoppedResponse")]
        System.Threading.Tasks.Task<bool> isInitiatorStoppedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/isInitiatorLoggedOn", ReplyAction="http://tempuri.org/IQuickfixProcessorService/isInitiatorLoggedOnResponse")]
        bool isInitiatorLoggedOn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/isInitiatorLoggedOn", ReplyAction="http://tempuri.org/IQuickfixProcessorService/isInitiatorLoggedOnResponse")]
        System.Threading.Tasks.Task<bool> isInitiatorLoggedOnAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/TestTCR", ReplyAction="http://tempuri.org/IQuickfixProcessorService/TestTCRResponse")]
        void TestTCR();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/TestTCR", ReplyAction="http://tempuri.org/IQuickfixProcessorService/TestTCRResponse")]
        System.Threading.Tasks.Task TestTCRAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/TestER", ReplyAction="http://tempuri.org/IQuickfixProcessorService/TestERResponse")]
        void TestER();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuickfixProcessorService/TestER", ReplyAction="http://tempuri.org/IQuickfixProcessorService/TestERResponse")]
        System.Threading.Tasks.Task TestERAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuickfixProcessorServiceChannel : OrderManagementSystem.QuickfixProcessorService.IQuickfixProcessorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuickfixProcessorServiceClient : System.ServiceModel.ClientBase<OrderManagementSystem.QuickfixProcessorService.IQuickfixProcessorService>, OrderManagementSystem.QuickfixProcessorService.IQuickfixProcessorService {
        
        public QuickfixProcessorServiceClient() {
        }
        
        public QuickfixProcessorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuickfixProcessorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuickfixProcessorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuickfixProcessorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InitiatorStart() {
            base.Channel.InitiatorStart();
        }
        
        public System.Threading.Tasks.Task InitiatorStartAsync() {
            return base.Channel.InitiatorStartAsync();
        }
        
        public void Init(string path) {
            base.Channel.Init(path);
        }
        
        public System.Threading.Tasks.Task InitAsync(string path) {
            return base.Channel.InitAsync(path);
        }
        
        public void InitiatorStop() {
            base.Channel.InitiatorStop();
        }
        
        public System.Threading.Tasks.Task InitiatorStopAsync() {
            return base.Channel.InitiatorStopAsync();
        }
        
        public bool isInitiatorStopped() {
            return base.Channel.isInitiatorStopped();
        }
        
        public System.Threading.Tasks.Task<bool> isInitiatorStoppedAsync() {
            return base.Channel.isInitiatorStoppedAsync();
        }
        
        public bool isInitiatorLoggedOn() {
            return base.Channel.isInitiatorLoggedOn();
        }
        
        public System.Threading.Tasks.Task<bool> isInitiatorLoggedOnAsync() {
            return base.Channel.isInitiatorLoggedOnAsync();
        }
        
        public void TestTCR() {
            base.Channel.TestTCR();
        }
        
        public System.Threading.Tasks.Task TestTCRAsync() {
            return base.Channel.TestTCRAsync();
        }
        
        public void TestER() {
            base.Channel.TestER();
        }
        
        public System.Threading.Tasks.Task TestERAsync() {
            return base.Channel.TestERAsync();
        }
    }
}
