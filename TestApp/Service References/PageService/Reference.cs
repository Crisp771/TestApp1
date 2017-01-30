﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestApp.PageService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Page", Namespace="http://example.com")]
    [System.SerializableAttribute()]
    public partial class Page : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PageContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PageContent {
            get {
                return this.PageContentField;
            }
            set {
                if ((object.ReferenceEquals(this.PageContentField, value) != true)) {
                    this.PageContentField = value;
                    this.RaisePropertyChanged("PageContent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageID {
            get {
                return this.PageIDField;
            }
            set {
                if ((this.PageIDField.Equals(value) != true)) {
                    this.PageIDField = value;
                    this.RaisePropertyChanged("PageID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PageService.IPageService")]
    public interface IPageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPageService/GetPageByID", ReplyAction="http://tempuri.org/IPageService/GetPageByIDResponse")]
        TestApp.PageService.Page GetPageByID(int pageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPageService/GetPageByID", ReplyAction="http://tempuri.org/IPageService/GetPageByIDResponse")]
        System.Threading.Tasks.Task<TestApp.PageService.Page> GetPageByIDAsync(int pageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPageService/GetPages", ReplyAction="http://tempuri.org/IPageService/GetPagesResponse")]
        TestApp.PageService.Page[] GetPages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPageService/GetPages", ReplyAction="http://tempuri.org/IPageService/GetPagesResponse")]
        System.Threading.Tasks.Task<TestApp.PageService.Page[]> GetPagesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPageServiceChannel : TestApp.PageService.IPageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PageServiceClient : System.ServiceModel.ClientBase<TestApp.PageService.IPageService>, TestApp.PageService.IPageService {
        
        public PageServiceClient() {
        }
        
        public PageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestApp.PageService.Page GetPageByID(int pageId) {
            return base.Channel.GetPageByID(pageId);
        }
        
        public System.Threading.Tasks.Task<TestApp.PageService.Page> GetPageByIDAsync(int pageId) {
            return base.Channel.GetPageByIDAsync(pageId);
        }
        
        public TestApp.PageService.Page[] GetPages() {
            return base.Channel.GetPages();
        }
        
        public System.Threading.Tasks.Task<TestApp.PageService.Page[]> GetPagesAsync() {
            return base.Channel.GetPagesAsync();
        }
    }
}