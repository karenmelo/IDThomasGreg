using IDThomasGreg.Domain.Entities;
using IDThomasGreg.Domain.Repositories;

namespace IDThomasGreg.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public Task<Cliente> AdicionarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> AtualizarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> BuscarCliente(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> RemoverCliente(Guid clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
