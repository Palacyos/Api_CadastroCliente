using System.Collections.Generic;

namespace CadastroCliente.Models.ViewModel
{
    public class ClienteViewModel
    {
        public string NomeCliente {get; set;}
        public List<Telefone> Telefone {get; set; }
        public string Email {get;set;}
        public Documento DocumetoCliente {get; set;}
        public Endereco Endereco {get; set;}
    }
}