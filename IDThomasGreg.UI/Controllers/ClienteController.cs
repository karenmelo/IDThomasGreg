using IDThomasGreg.Domain.Entities;
using IDThomasGreg.Domain.Services.Interfaces;
using IDThomasGreg.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IDThomasGreg.UI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet("buscar_cliente")]
        public async Task<IActionResult> Get()
        {
            return View();
        }

        [HttpPost("criar_cliente")]
        public IActionResult Post(ClienteModel clienteModel)
        {
            var cliente = new Cliente
            (
                clienteModel.Nome,
                clienteModel.Email,
                clienteModel.Logotipo,
                new List<Endereco> { new Endereco { Logradouro = clienteModel.Logradouro } }
            );
            _clienteService.Criar(cliente);
            return View();
        }

        [HttpPut("alterar_cliente")]
        public async Task<IActionResult> Put()
        {
            return View();
        }

        [HttpDelete("remover_cliente")]
        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
