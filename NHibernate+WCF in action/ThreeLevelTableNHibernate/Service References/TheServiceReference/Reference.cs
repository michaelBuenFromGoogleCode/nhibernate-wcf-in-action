﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeLevelTableNHibernate.TheServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Question", Namespace="http://schemas.datacontract.org/2004/07/TheEntities", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Question : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ThreeLevelTableNHibernate.TheServiceReference.Answer> AnswersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ThreeLevelTableNHibernate.TheServiceReference.QuestionComment> CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuestionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TheQuestionField;
        
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
        public System.Collections.Generic.List<ThreeLevelTableNHibernate.TheServiceReference.Answer> Answers {
            get {
                return this.AnswersField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswersField, value) != true)) {
                    this.AnswersField = value;
                    this.RaisePropertyChanged("Answers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ThreeLevelTableNHibernate.TheServiceReference.QuestionComment> Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Poster {
            get {
                return this.PosterField;
            }
            set {
                if ((object.ReferenceEquals(this.PosterField, value) != true)) {
                    this.PosterField = value;
                    this.RaisePropertyChanged("Poster");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuestionId {
            get {
                return this.QuestionIdField;
            }
            set {
                if ((this.QuestionIdField.Equals(value) != true)) {
                    this.QuestionIdField = value;
                    this.RaisePropertyChanged("QuestionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TheQuestion {
            get {
                return this.TheQuestionField;
            }
            set {
                if ((object.ReferenceEquals(this.TheQuestionField, value) != true)) {
                    this.TheQuestionField = value;
                    this.RaisePropertyChanged("TheQuestion");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Answer", Namespace="http://schemas.datacontract.org/2004/07/TheEntities", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Answer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AnswerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ThreeLevelTableNHibernate.TheServiceReference.AnswerComment> CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ThreeLevelTableNHibernate.TheServiceReference.Question QuestionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TheAnswerField;
        
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
        public int AnswerId {
            get {
                return this.AnswerIdField;
            }
            set {
                if ((this.AnswerIdField.Equals(value) != true)) {
                    this.AnswerIdField = value;
                    this.RaisePropertyChanged("AnswerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ThreeLevelTableNHibernate.TheServiceReference.AnswerComment> Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Poster {
            get {
                return this.PosterField;
            }
            set {
                if ((object.ReferenceEquals(this.PosterField, value) != true)) {
                    this.PosterField = value;
                    this.RaisePropertyChanged("Poster");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ThreeLevelTableNHibernate.TheServiceReference.Question Question {
            get {
                return this.QuestionField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionField, value) != true)) {
                    this.QuestionField = value;
                    this.RaisePropertyChanged("Question");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TheAnswer {
            get {
                return this.TheAnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.TheAnswerField, value) != true)) {
                    this.TheAnswerField = value;
                    this.RaisePropertyChanged("TheAnswer");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuestionComment", Namespace="http://schemas.datacontract.org/2004/07/TheEntities")]
    [System.SerializableAttribute()]
    public partial class QuestionComment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ThreeLevelTableNHibernate.TheServiceReference.Question QuestionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuestionCommentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TheQuestionCommentField;
        
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
        public string Poster {
            get {
                return this.PosterField;
            }
            set {
                if ((object.ReferenceEquals(this.PosterField, value) != true)) {
                    this.PosterField = value;
                    this.RaisePropertyChanged("Poster");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ThreeLevelTableNHibernate.TheServiceReference.Question Question {
            get {
                return this.QuestionField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionField, value) != true)) {
                    this.QuestionField = value;
                    this.RaisePropertyChanged("Question");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuestionCommentId {
            get {
                return this.QuestionCommentIdField;
            }
            set {
                if ((this.QuestionCommentIdField.Equals(value) != true)) {
                    this.QuestionCommentIdField = value;
                    this.RaisePropertyChanged("QuestionCommentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TheQuestionComment {
            get {
                return this.TheQuestionCommentField;
            }
            set {
                if ((object.ReferenceEquals(this.TheQuestionCommentField, value) != true)) {
                    this.TheQuestionCommentField = value;
                    this.RaisePropertyChanged("TheQuestionComment");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnswerComment", Namespace="http://schemas.datacontract.org/2004/07/TheEntities")]
    [System.SerializableAttribute()]
    public partial class AnswerComment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ThreeLevelTableNHibernate.TheServiceReference.Answer AnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AnswerCommentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TheAnswerCommentField;
        
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
        public ThreeLevelTableNHibernate.TheServiceReference.Answer Answer {
            get {
                return this.AnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswerField, value) != true)) {
                    this.AnswerField = value;
                    this.RaisePropertyChanged("Answer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AnswerCommentId {
            get {
                return this.AnswerCommentIdField;
            }
            set {
                if ((this.AnswerCommentIdField.Equals(value) != true)) {
                    this.AnswerCommentIdField = value;
                    this.RaisePropertyChanged("AnswerCommentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Poster {
            get {
                return this.PosterField;
            }
            set {
                if ((object.ReferenceEquals(this.PosterField, value) != true)) {
                    this.PosterField = value;
                    this.RaisePropertyChanged("Poster");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TheAnswerComment {
            get {
                return this.TheAnswerCommentField;
            }
            set {
                if ((object.ReferenceEquals(this.TheAnswerCommentField, value) != true)) {
                    this.TheAnswerCommentField = value;
                    this.RaisePropertyChanged("TheAnswerComment");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TheServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/NewQuestion", ReplyAction="http://tempuri.org/IService/NewQuestionResponse")]
        ThreeLevelTableNHibernate.TheServiceReference.Question NewQuestion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SaveQuestion", ReplyAction="http://tempuri.org/IService/SaveQuestionResponse")]
        int SaveQuestion(ThreeLevelTableNHibernate.TheServiceReference.Question q);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/OpenQuestion", ReplyAction="http://tempuri.org/IService/OpenQuestionResponse")]
        ThreeLevelTableNHibernate.TheServiceReference.Question OpenQuestion(int questionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SaveTheQuestion", ReplyAction="http://tempuri.org/IService/SaveTheQuestionResponse")]
        int SaveTheQuestion();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ThreeLevelTableNHibernate.TheServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ThreeLevelTableNHibernate.TheServiceReference.IService>, ThreeLevelTableNHibernate.TheServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public ThreeLevelTableNHibernate.TheServiceReference.Question NewQuestion() {
            return base.Channel.NewQuestion();
        }
        
        public int SaveQuestion(ThreeLevelTableNHibernate.TheServiceReference.Question q) {
            return base.Channel.SaveQuestion(q);
        }
        
        public ThreeLevelTableNHibernate.TheServiceReference.Question OpenQuestion(int questionId) {
            return base.Channel.OpenQuestion(questionId);
        }
        
        public int SaveTheQuestion() {
            return base.Channel.SaveTheQuestion();
        }
    }
}
