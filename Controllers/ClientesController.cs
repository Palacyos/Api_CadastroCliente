using System.Collections.Generic;
using CadastroCliente.Models;

using CadastroCliente.Models.ViewModel;
using CadastroCliente.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCliente.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private ClienteService ClienteService {get;}

        public ClientesController(ClienteService clienteService)
        {
            ClienteService = clienteService;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> Get() => ClienteService.Get();

        [HttpGet("{id:length(24)}", Name = "GetCliente")]
        public ActionResult<Cliente> Get(string id)
        {
            var cliente = ClienteService.GetById(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPost]
        public ActionResult<Cliente> Create([FromBody]ClienteViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel.NomeCliente, clienteViewModel.Telefone, clienteViewModel.Email,
            clienteViewModel.DocumetoCliente, clienteViewModel.Endereco);

            ClienteService.Create(cliente);

           return CreatedAtRoute("GetCliente", new { id = cliente.Id.ToString() }, cliente);

        } 

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Cliente cliente)
        {
            var c = ClienteService.GetById(id);

            if (c == null)
            {
                return NotFound();
            }

            
            ClienteService.Update(id, cliente);

            return NoContent();

        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var cliente = ClienteService.GetById(id);

            if (cliente == null)
            {
                return NotFound();
            }

            ClienteService.Remove(cliente.Id);

            return NoContent();
        }
    }
    
}