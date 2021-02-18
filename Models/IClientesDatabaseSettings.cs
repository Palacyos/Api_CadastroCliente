namespace CadastroCliente.Models
{
    public interface IClientesDatabaseSettings
    {
        string ClientesCollectionName {get; set;}
        string ConnectionString {get; set;}
        string DatabaseName{get; set;}


    }
}