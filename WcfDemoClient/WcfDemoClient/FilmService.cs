﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDemo.DataAccess
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Film", Namespace="http://schemas.datacontract.org/2004/07/WcfDemo.DataAccess")]
    public partial class Film : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        private string nameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IFilmService")]
public interface IFilmService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilmService/GetAllFilms", ReplyAction="http://tempuri.org/IFilmService/GetAllFilmsResponse")]
    WcfDemo.DataAccess.Film[] GetAllFilms();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilmService/GetAllFilms", ReplyAction="http://tempuri.org/IFilmService/GetAllFilmsResponse")]
    System.Threading.Tasks.Task<WcfDemo.DataAccess.Film[]> GetAllFilmsAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IFilmServiceChannel : IFilmService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class FilmServiceClient : System.ServiceModel.ClientBase<IFilmService>, IFilmService
{
    
    public FilmServiceClient()
    {
    }
    
    public FilmServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public FilmServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public FilmServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public FilmServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public WcfDemo.DataAccess.Film[] GetAllFilms()
    {
        return base.Channel.GetAllFilms();
    }
    
    public System.Threading.Tasks.Task<WcfDemo.DataAccess.Film[]> GetAllFilmsAsync()
    {
        return base.Channel.GetAllFilmsAsync();
    }
}
