﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFORMKLShop.ServiceReferenceCTPhieuNhapCustom {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CTPhieuNhapCustom", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceKLShop.Model")]
    [System.SerializableAttribute()]
    public partial class CTPhieuNhapCustom : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MaPNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MaSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SoLuongField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenSPField;
        
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
        public System.Nullable<int> ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MaPN {
            get {
                return this.MaPNField;
            }
            set {
                if ((this.MaPNField.Equals(value) != true)) {
                    this.MaPNField = value;
                    this.RaisePropertyChanged("MaPN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MaSP {
            get {
                return this.MaSPField;
            }
            set {
                if ((this.MaSPField.Equals(value) != true)) {
                    this.MaSPField = value;
                    this.RaisePropertyChanged("MaSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SoLuong {
            get {
                return this.SoLuongField;
            }
            set {
                if ((this.SoLuongField.Equals(value) != true)) {
                    this.SoLuongField = value;
                    this.RaisePropertyChanged("SoLuong");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenSP {
            get {
                return this.TenSPField;
            }
            set {
                if ((object.ReferenceEquals(this.TenSPField, value) != true)) {
                    this.TenSPField = value;
                    this.RaisePropertyChanged("TenSP");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCTPhieuNhapCustom.IServiceCTPhieuNhapCustom")]
    public interface IServiceCTPhieuNhapCustom {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCTPhieuNhapCustom/CTPhieuNhap", ReplyAction="http://tempuri.org/IServiceCTPhieuNhapCustom/CTPhieuNhapResponse")]
        WFORMKLShop.ServiceReferenceCTPhieuNhapCustom.CTPhieuNhapCustom[] CTPhieuNhap(int mapn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCTPhieuNhapCustom/CTPhieuNhap", ReplyAction="http://tempuri.org/IServiceCTPhieuNhapCustom/CTPhieuNhapResponse")]
        System.Threading.Tasks.Task<WFORMKLShop.ServiceReferenceCTPhieuNhapCustom.CTPhieuNhapCustom[]> CTPhieuNhapAsync(int mapn);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCTPhieuNhapCustomChannel : WFORMKLShop.ServiceReferenceCTPhieuNhapCustom.IServiceCTPhieuNhapCustom, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCTPhieuNhapCustomClient : System.ServiceModel.ClientBase<WFORMKLShop.ServiceReferenceCTPhieuNhapCustom.IServiceCTPhieuNhapCustom>, WFORMKLShop.ServiceReferenceCTPhieuNhapCustom.IServiceCTPhieuNhapCustom {
        
        public ServiceCTPhieuNhapCustomClient() {
        }
        
        public ServiceCTPhieuNhapCustomClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCTPhieuNhapCustomClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCTPhieuNhapCustomClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCTPhieuNhapCustomClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WFORMKLShop.ServiceReferenceCTPhieuNhapCustom.CTPhieuNhapCustom[] CTPhieuNhap(int mapn) {
            return base.Channel.CTPhieuNhap(mapn);
        }
        
        public System.Threading.Tasks.Task<WFORMKLShop.ServiceReferenceCTPhieuNhapCustom.CTPhieuNhapCustom[]> CTPhieuNhapAsync(int mapn) {
            return base.Channel.CTPhieuNhapAsync(mapn);
        }
    }
}
