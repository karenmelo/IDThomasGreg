using IDThomasGreg.Domain.Entities;
using IDThomasGreg.Domain.Repositories;
using IDThomasGreg.Domain.Services.Interfaces;

namespace IDThomasGreg.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Atualizar(Cliente cliente)
        {
            try
            {
               await _clienteRepository.AtualizarCliente(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Criar(Cliente cliente)
        {
           _clienteRepository.AdicionarCliente(cliente);
        }

        public async Task Remover(Guid idCliente)
        {
            await _clienteRepository.RemoverCliente(idCliente);
        }

        public async Task Visualizar(Guid idCliente)
        {
            await _clienteRepository.RemoverCliente(idCliente);
        }
    }
}
