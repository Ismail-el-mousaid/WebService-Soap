//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWS_.Net.SR1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservice/", ConfigurationName="SR1.BanqueService")]
    public interface BanqueService {
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/BanqueService/listComptesRequest", ReplyAction="http://webservice/BanqueService/listComptesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClientWS_.Net.SR1.listComptesResponse listComptes(ClientWS_.Net.SR1.listComptesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/BanqueService/listComptesRequest", ReplyAction="http://webservice/BanqueService/listComptesResponse")]
        System.Threading.Tasks.Task<ClientWS_.Net.SR1.listComptesResponse> listComptesAsync(ClientWS_.Net.SR1.listComptesRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/BanqueService/getCompteRequest", ReplyAction="http://webservice/BanqueService/getCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClientWS_.Net.SR1.getCompteResponse getCompte(ClientWS_.Net.SR1.getCompteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/BanqueService/getCompteRequest", ReplyAction="http://webservice/BanqueService/getCompteResponse")]
        System.Threading.Tasks.Task<ClientWS_.Net.SR1.getCompteResponse> getCompteAsync(ClientWS_.Net.SR1.getCompteRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/BanqueService/ConversionEurotoDHRequest", ReplyAction="http://webservice/BanqueService/ConversionEurotoDHResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClientWS_.Net.SR1.ConversionEurotoDHResponse ConversionEurotoDH(ClientWS_.Net.SR1.ConversionEurotoDHRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/BanqueService/ConversionEurotoDHRequest", ReplyAction="http://webservice/BanqueService/ConversionEurotoDHResponse")]
        System.Threading.Tasks.Task<ClientWS_.Net.SR1.ConversionEurotoDHResponse> ConversionEurotoDHAsync(ClientWS_.Net.SR1.ConversionEurotoDHRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice/")]
    public partial class compte : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long codeField;
        
        private bool codeFieldSpecified;
        
        private double soldeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codeSpecified {
            get {
                return this.codeFieldSpecified;
            }
            set {
                this.codeFieldSpecified = value;
                this.RaisePropertyChanged("codeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double solde {
            get {
                return this.soldeField;
            }
            set {
                this.soldeField = value;
                this.RaisePropertyChanged("solde");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listComptes", WrapperNamespace="http://webservice/", IsWrapped=true)]
    public partial class listComptesRequest {
        
        public listComptesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listComptesResponse", WrapperNamespace="http://webservice/", IsWrapped=true)]
    public partial class listComptesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClientWS_.Net.SR1.compte[] @return;
        
        public listComptesResponse() {
        }
        
        public listComptesResponse(ClientWS_.Net.SR1.compte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompte", WrapperNamespace="http://webservice/", IsWrapped=true)]
    public partial class getCompteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long code;
        
        public getCompteRequest() {
        }
        
        public getCompteRequest(long code) {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompteResponse", WrapperNamespace="http://webservice/", IsWrapped=true)]
    public partial class getCompteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClientWS_.Net.SR1.compte @return;
        
        public getCompteResponse() {
        }
        
        public getCompteResponse(ClientWS_.Net.SR1.compte @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEurotoDH", WrapperNamespace="http://webservice/", IsWrapped=true)]
    public partial class ConversionEurotoDHRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double montant;
        
        public ConversionEurotoDHRequest() {
        }
        
        public ConversionEurotoDHRequest(double montant) {
            this.montant = montant;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEurotoDHResponse", WrapperNamespace="http://webservice/", IsWrapped=true)]
    public partial class ConversionEurotoDHResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public ConversionEurotoDHResponse() {
        }
        
        public ConversionEurotoDHResponse(double @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BanqueServiceChannel : ClientWS_.Net.SR1.BanqueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BanqueServiceClient : System.ServiceModel.ClientBase<ClientWS_.Net.SR1.BanqueService>, ClientWS_.Net.SR1.BanqueService {
        
        public BanqueServiceClient() {
        }
        
        public BanqueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientWS_.Net.SR1.listComptesResponse ClientWS_.Net.SR1.BanqueService.listComptes(ClientWS_.Net.SR1.listComptesRequest request) {
            return base.Channel.listComptes(request);
        }
        
        public ClientWS_.Net.SR1.compte[] listComptes() {
            ClientWS_.Net.SR1.listComptesRequest inValue = new ClientWS_.Net.SR1.listComptesRequest();
            ClientWS_.Net.SR1.listComptesResponse retVal = ((ClientWS_.Net.SR1.BanqueService)(this)).listComptes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientWS_.Net.SR1.listComptesResponse> ClientWS_.Net.SR1.BanqueService.listComptesAsync(ClientWS_.Net.SR1.listComptesRequest request) {
            return base.Channel.listComptesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientWS_.Net.SR1.listComptesResponse> listComptesAsync() {
            ClientWS_.Net.SR1.listComptesRequest inValue = new ClientWS_.Net.SR1.listComptesRequest();
            return ((ClientWS_.Net.SR1.BanqueService)(this)).listComptesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientWS_.Net.SR1.getCompteResponse ClientWS_.Net.SR1.BanqueService.getCompte(ClientWS_.Net.SR1.getCompteRequest request) {
            return base.Channel.getCompte(request);
        }
        
        public ClientWS_.Net.SR1.compte getCompte(long code) {
            ClientWS_.Net.SR1.getCompteRequest inValue = new ClientWS_.Net.SR1.getCompteRequest();
            inValue.code = code;
            ClientWS_.Net.SR1.getCompteResponse retVal = ((ClientWS_.Net.SR1.BanqueService)(this)).getCompte(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientWS_.Net.SR1.getCompteResponse> ClientWS_.Net.SR1.BanqueService.getCompteAsync(ClientWS_.Net.SR1.getCompteRequest request) {
            return base.Channel.getCompteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientWS_.Net.SR1.getCompteResponse> getCompteAsync(long code) {
            ClientWS_.Net.SR1.getCompteRequest inValue = new ClientWS_.Net.SR1.getCompteRequest();
            inValue.code = code;
            return ((ClientWS_.Net.SR1.BanqueService)(this)).getCompteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientWS_.Net.SR1.ConversionEurotoDHResponse ClientWS_.Net.SR1.BanqueService.ConversionEurotoDH(ClientWS_.Net.SR1.ConversionEurotoDHRequest request) {
            return base.Channel.ConversionEurotoDH(request);
        }
        
        public double ConversionEurotoDH(double montant) {
            ClientWS_.Net.SR1.ConversionEurotoDHRequest inValue = new ClientWS_.Net.SR1.ConversionEurotoDHRequest();
            inValue.montant = montant;
            ClientWS_.Net.SR1.ConversionEurotoDHResponse retVal = ((ClientWS_.Net.SR1.BanqueService)(this)).ConversionEurotoDH(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientWS_.Net.SR1.ConversionEurotoDHResponse> ClientWS_.Net.SR1.BanqueService.ConversionEurotoDHAsync(ClientWS_.Net.SR1.ConversionEurotoDHRequest request) {
            return base.Channel.ConversionEurotoDHAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientWS_.Net.SR1.ConversionEurotoDHResponse> ConversionEurotoDHAsync(double montant) {
            ClientWS_.Net.SR1.ConversionEurotoDHRequest inValue = new ClientWS_.Net.SR1.ConversionEurotoDHRequest();
            inValue.montant = montant;
            return ((ClientWS_.Net.SR1.BanqueService)(this)).ConversionEurotoDHAsync(inValue);
        }
    }
}
