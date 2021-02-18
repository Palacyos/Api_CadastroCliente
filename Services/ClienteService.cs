using System.Collections.Generic;
using CadastroCliente.Models;
using MongoDB.Driver;

namespace CadastroCliente.Services
{
    public class ClienteService
    {
        private IMongoCollection<Cliente> clientes {get;}

        public ClienteService(IClientesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            clientes = database.GetCollection<Cliente>(settings.ClientesCollectionName);
        }

        //obtem todos os clientes cadastrados
        public List<Cliente> Get() => clientes.Find(cliente => true).ToList(); 

        //obtem um cliente 
        public Cliente GetById (string id) => clientes.Find<Cliente>(cliente => cliente.Id == id ).FirstOrDefault(); 

        //insere um cliente
        public Cliente Create(Cliente cliente)
        {
            clientes.InsertOne(cliente);
            return cliente;
        }

        //atualiza um cliente
        public void Update(string id, Cliente cliente) => clientes.ReplaceOne(cliente => cliente.Id == id, cliente);

        //remove um cliente
        public void Remove(string id) => clientes.DeleteOne(cliente => cliente.Id == id);
        

        

    }
}