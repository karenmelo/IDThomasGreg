using IDThomasGreg.Domain.Entities;

namespace IDThomasGreg.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> BuscarCliente(Guid clienteId);
        void AdicionarCliente(Cliente cliente);
        Task<Cliente> AtualizarCliente(Cliente cliente);
        Task<Cliente> RemoverCliente(Guid clienteId);
    }
}
