﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18052.
// 
#pragma warning disable 1591

namespace UI.BLLIni {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSIniSoap", Namespace="http://tempuri.org/")]
    public partial class WSIni : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getServerPathOperationCompleted;
        
        private System.Threading.SendOrPostCallback IniWriteValueOperationCompleted;
        
        private System.Threading.SendOrPostCallback IniReadValueOperationCompleted;
        
        private System.Threading.SendOrPostCallback getServerTimeOperationCompleted;
        
        private System.Threading.SendOrPostCallback serverHasIniOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSIni() {
            this.Url = global::UI.Properties.Settings.Default.YogaHouseMgr_BLLIni_WSIni;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getServerPathCompletedEventHandler getServerPathCompleted;
        
        /// <remarks/>
        public event IniWriteValueCompletedEventHandler IniWriteValueCompleted;
        
        /// <remarks/>
        public event IniReadValueCompletedEventHandler IniReadValueCompleted;
        
        /// <remarks/>
        public event getServerTimeCompletedEventHandler getServerTimeCompleted;
        
        /// <remarks/>
        public event serverHasIniCompletedEventHandler serverHasIniCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getServerPath", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getServerPath() {
            object[] results = this.Invoke("getServerPath", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getServerPathAsync() {
            this.getServerPathAsync(null);
        }
        
        /// <remarks/>
        public void getServerPathAsync(object userState) {
            if ((this.getServerPathOperationCompleted == null)) {
                this.getServerPathOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetServerPathOperationCompleted);
            }
            this.InvokeAsync("getServerPath", new object[0], this.getServerPathOperationCompleted, userState);
        }
        
        private void OngetServerPathOperationCompleted(object arg) {
            if ((this.getServerPathCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getServerPathCompleted(this, new getServerPathCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IniWriteValue", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void IniWriteValue(string Section, string Key, string Value) {
            this.Invoke("IniWriteValue", new object[] {
                        Section,
                        Key,
                        Value});
        }
        
        /// <remarks/>
        public void IniWriteValueAsync(string Section, string Key, string Value) {
            this.IniWriteValueAsync(Section, Key, Value, null);
        }
        
        /// <remarks/>
        public void IniWriteValueAsync(string Section, string Key, string Value, object userState) {
            if ((this.IniWriteValueOperationCompleted == null)) {
                this.IniWriteValueOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIniWriteValueOperationCompleted);
            }
            this.InvokeAsync("IniWriteValue", new object[] {
                        Section,
                        Key,
                        Value}, this.IniWriteValueOperationCompleted, userState);
        }
        
        private void OnIniWriteValueOperationCompleted(object arg) {
            if ((this.IniWriteValueCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IniWriteValueCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IniReadValue", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string IniReadValue(string Section, string Key) {
            object[] results = this.Invoke("IniReadValue", new object[] {
                        Section,
                        Key});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void IniReadValueAsync(string Section, string Key) {
            this.IniReadValueAsync(Section, Key, null);
        }
        
        /// <remarks/>
        public void IniReadValueAsync(string Section, string Key, object userState) {
            if ((this.IniReadValueOperationCompleted == null)) {
                this.IniReadValueOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIniReadValueOperationCompleted);
            }
            this.InvokeAsync("IniReadValue", new object[] {
                        Section,
                        Key}, this.IniReadValueOperationCompleted, userState);
        }
        
        private void OnIniReadValueOperationCompleted(object arg) {
            if ((this.IniReadValueCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IniReadValueCompleted(this, new IniReadValueCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getServerTime", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.DateTime getServerTime() {
            object[] results = this.Invoke("getServerTime", new object[0]);
            return ((System.DateTime)(results[0]));
        }
        
        /// <remarks/>
        public void getServerTimeAsync() {
            this.getServerTimeAsync(null);
        }
        
        /// <remarks/>
        public void getServerTimeAsync(object userState) {
            if ((this.getServerTimeOperationCompleted == null)) {
                this.getServerTimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetServerTimeOperationCompleted);
            }
            this.InvokeAsync("getServerTime", new object[0], this.getServerTimeOperationCompleted, userState);
        }
        
        private void OngetServerTimeOperationCompleted(object arg) {
            if ((this.getServerTimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getServerTimeCompleted(this, new getServerTimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/serverHasIni", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool serverHasIni() {
            object[] results = this.Invoke("serverHasIni", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void serverHasIniAsync() {
            this.serverHasIniAsync(null);
        }
        
        /// <remarks/>
        public void serverHasIniAsync(object userState) {
            if ((this.serverHasIniOperationCompleted == null)) {
                this.serverHasIniOperationCompleted = new System.Threading.SendOrPostCallback(this.OnserverHasIniOperationCompleted);
            }
            this.InvokeAsync("serverHasIni", new object[0], this.serverHasIniOperationCompleted, userState);
        }
        
        private void OnserverHasIniOperationCompleted(object arg) {
            if ((this.serverHasIniCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.serverHasIniCompleted(this, new serverHasIniCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getServerPathCompletedEventHandler(object sender, getServerPathCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getServerPathCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getServerPathCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void IniWriteValueCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void IniReadValueCompletedEventHandler(object sender, IniReadValueCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IniReadValueCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IniReadValueCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getServerTimeCompletedEventHandler(object sender, getServerTimeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getServerTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getServerTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.DateTime Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void serverHasIniCompletedEventHandler(object sender, serverHasIniCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class serverHasIniCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal serverHasIniCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591