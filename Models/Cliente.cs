using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CadastroCliente.Models
{
    public class Cliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;}

        [BsonElement("Nome")]
        public string NomeCliente {get; set;}
        public List<Telefone> Telefone {get; set;}
        public string Email {get; set;}

        [BsonElement("Documento")]
        public Documento DocumetoCliente {get; set;}
        
        [BsonElement("Endereço")]
        public Endereco Endereco {get; set;}

        public Cliente(string nomeCliente, List<Telefone> telefone, string email, Documento documentoCliente, Endereco endereco)
        {
            NomeCliente = nomeCliente;
            Telefone = telefone;
            Email = email;
            DocumetoCliente = documentoCliente;
            Endereco = endereco;

        }
    }
}