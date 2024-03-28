using IDThomasGreg.Domain.Entities;
using IDThomasGreg.Domain.Repositories;

namespace IDThomasGreg.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        public Task<Cliente> AdicionarLogradouro(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> AtualizarLogradouro(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> BuscarLogradouro(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> RemoverLogradouro(Guid clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
