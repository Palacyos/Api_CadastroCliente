namespace CadastroCliente.Models
{
    public class ClientesDatabaseSettings : IClientesDatabaseSettings
    {
        public string ClientesCollectionName{ get; set;}
        public string ConnectionString {get; set;}
        public string DatabaseName{get; set;}
        
    }
}