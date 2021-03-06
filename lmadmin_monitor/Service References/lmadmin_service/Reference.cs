﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lmadmin_monitor.lmadmin_service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:fnplm:lmadmin", ConfigurationName="lmadmin_service.LicenseServerPortType")]
    public interface LicenseServerPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="output")]
        string getAlerts(string sessionid, string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="output")]
        System.Threading.Tasks.Task<string> getAlertsAsync(string sessionid, string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="output")]
        string getSessionId(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="output")]
        System.Threading.Tasks.Task<string> getSessionIdAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LicenseServerPortTypeChannel : lmadmin_monitor.lmadmin_service.LicenseServerPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LicenseServerPortTypeClient : System.ServiceModel.ClientBase<lmadmin_monitor.lmadmin_service.LicenseServerPortType>, lmadmin_monitor.lmadmin_service.LicenseServerPortType {
        
        public LicenseServerPortTypeClient() {
        }
        
        public LicenseServerPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LicenseServerPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LicenseServerPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LicenseServerPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getAlerts(string sessionid, string filter) {
            return base.Channel.getAlerts(sessionid, filter);
        }
        
        public System.Threading.Tasks.Task<string> getAlertsAsync(string sessionid, string filter) {
            return base.Channel.getAlertsAsync(sessionid, filter);
        }
        
        public string getSessionId(string username, string password) {
            return base.Channel.getSessionId(username, password);
        }
        
        public System.Threading.Tasks.Task<string> getSessionIdAsync(string username, string password) {
            return base.Channel.getSessionIdAsync(username, password);
        }
    }
}
