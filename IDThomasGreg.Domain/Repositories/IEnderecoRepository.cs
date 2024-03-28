using IDThomasGreg.Domain.Entities;

namespace IDThomasGreg.Domain.Repositories
{
    public interface IEnderecoRepository
    {
        Task<Cliente> BuscarLogradouro(Guid clienteId);
        Task<Cliente> AdicionarLogradouro(Cliente cliente);
        Task<Cliente> AtualizarLogradouro(Cliente cliente);
        Task<Cliente> RemoverLogradouro(Guid clienteId);
    }
}
