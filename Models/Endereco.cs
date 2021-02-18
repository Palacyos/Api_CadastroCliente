using MongoDB.Bson.Serialization.Attributes;

namespace CadastroCliente.Models
{
    public class Endereco
    {
        public string Cidade {get; set;}
        public string Rua {get; set;}
        public string Bairro {get; set;}
        public string Numero {get; set;}
        public string CEP {get; set;}
        public string Complemento {get; set;}
        
    }
}