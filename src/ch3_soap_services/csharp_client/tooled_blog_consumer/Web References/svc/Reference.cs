﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace tooled_blog_consumer.svc {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BlogSoap", Namespace="http://tempuri.org/")]
    public partial class Blog : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AllPostsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPostOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreatePostOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdatePostOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeletePostOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Blog() {
            this.Url = global::tooled_blog_consumer.Properties.Settings.Default.tooled_blog_consumer_svc_Blog;
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
        public event AllPostsCompletedEventHandler AllPostsCompleted;
        
        /// <remarks/>
        public event GetPostCompletedEventHandler GetPostCompleted;
        
        /// <remarks/>
        public event CreatePostCompletedEventHandler CreatePostCompleted;
        
        /// <remarks/>
        public event UpdatePostCompletedEventHandler UpdatePostCompleted;
        
        /// <remarks/>
        public event DeletePostCompletedEventHandler DeletePostCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AllPosts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Post[] AllPosts() {
            object[] results = this.Invoke("AllPosts", new object[0]);
            return ((Post[])(results[0]));
        }
        
        /// <remarks/>
        public void AllPostsAsync() {
            this.AllPostsAsync(null);
        }
        
        /// <remarks/>
        public void AllPostsAsync(object userState) {
            if ((this.AllPostsOperationCompleted == null)) {
                this.AllPostsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllPostsOperationCompleted);
            }
            this.InvokeAsync("AllPosts", new object[0], this.AllPostsOperationCompleted, userState);
        }
        
        private void OnAllPostsOperationCompleted(object arg) {
            if ((this.AllPostsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AllPostsCompleted(this, new AllPostsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPost", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Post GetPost(string id) {
            object[] results = this.Invoke("GetPost", new object[] {
                        id});
            return ((Post)(results[0]));
        }
        
        /// <remarks/>
        public void GetPostAsync(string id) {
            this.GetPostAsync(id, null);
        }
        
        /// <remarks/>
        public void GetPostAsync(string id, object userState) {
            if ((this.GetPostOperationCompleted == null)) {
                this.GetPostOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPostOperationCompleted);
            }
            this.InvokeAsync("GetPost", new object[] {
                        id}, this.GetPostOperationCompleted, userState);
        }
        
        private void OnGetPostOperationCompleted(object arg) {
            if ((this.GetPostCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPostCompleted(this, new GetPostCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CreatePost", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Post CreatePost(string title, string content, int viewCount) {
            object[] results = this.Invoke("CreatePost", new object[] {
                        title,
                        content,
                        viewCount});
            return ((Post)(results[0]));
        }
        
        /// <remarks/>
        public void CreatePostAsync(string title, string content, int viewCount) {
            this.CreatePostAsync(title, content, viewCount, null);
        }
        
        /// <remarks/>
        public void CreatePostAsync(string title, string content, int viewCount, object userState) {
            if ((this.CreatePostOperationCompleted == null)) {
                this.CreatePostOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreatePostOperationCompleted);
            }
            this.InvokeAsync("CreatePost", new object[] {
                        title,
                        content,
                        viewCount}, this.CreatePostOperationCompleted, userState);
        }
        
        private void OnCreatePostOperationCompleted(object arg) {
            if ((this.CreatePostCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreatePostCompleted(this, new CreatePostCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdatePost", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Post UpdatePost(string id, string title, string content, int viewCount) {
            object[] results = this.Invoke("UpdatePost", new object[] {
                        id,
                        title,
                        content,
                        viewCount});
            return ((Post)(results[0]));
        }
        
        /// <remarks/>
        public void UpdatePostAsync(string id, string title, string content, int viewCount) {
            this.UpdatePostAsync(id, title, content, viewCount, null);
        }
        
        /// <remarks/>
        public void UpdatePostAsync(string id, string title, string content, int viewCount, object userState) {
            if ((this.UpdatePostOperationCompleted == null)) {
                this.UpdatePostOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdatePostOperationCompleted);
            }
            this.InvokeAsync("UpdatePost", new object[] {
                        id,
                        title,
                        content,
                        viewCount}, this.UpdatePostOperationCompleted, userState);
        }
        
        private void OnUpdatePostOperationCompleted(object arg) {
            if ((this.UpdatePostCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdatePostCompleted(this, new UpdatePostCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeletePost", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeletePost(string id) {
            this.Invoke("DeletePost", new object[] {
                        id});
        }
        
        /// <remarks/>
        public void DeletePostAsync(string id) {
            this.DeletePostAsync(id, null);
        }
        
        /// <remarks/>
        public void DeletePostAsync(string id, object userState) {
            if ((this.DeletePostOperationCompleted == null)) {
                this.DeletePostOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeletePostOperationCompleted);
            }
            this.InvokeAsync("DeletePost", new object[] {
                        id}, this.DeletePostOperationCompleted, userState);
        }
        
        private void OnDeletePostOperationCompleted(object arg) {
            if ((this.DeletePostCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeletePostCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Post {
        
        private string idField;
        
        private string titleField;
        
        private string publishedField;
        
        private string contentField;
        
        private int viewCountField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Published {
            get {
                return this.publishedField;
            }
            set {
                this.publishedField = value;
            }
        }
        
        /// <remarks/>
        public string Content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        public int ViewCount {
            get {
                return this.viewCountField;
            }
            set {
                this.viewCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void AllPostsCompletedEventHandler(object sender, AllPostsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AllPostsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AllPostsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Post[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Post[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetPostCompletedEventHandler(object sender, GetPostCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPostCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPostCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Post Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Post)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void CreatePostCompletedEventHandler(object sender, CreatePostCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreatePostCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreatePostCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Post Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Post)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void UpdatePostCompletedEventHandler(object sender, UpdatePostCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdatePostCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdatePostCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Post Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Post)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void DeletePostCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591