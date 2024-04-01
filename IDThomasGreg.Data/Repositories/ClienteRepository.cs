using IDThomasGreg.Domain.Entities;
using IDThomasGreg.Domain.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace IDThomasGreg.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _dataContext;

        public ClienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _dataContext.Database.ExecuteSqlRaw("dbo.CriarCliente @id, @nome, @email, @logradouro, @idEndereco");
            new SqlParameter("@id",cliente.Id);
            new SqlParameter("@nome",cliente.Nome);
            new SqlParameter("@email",cliente.Email);
            new SqlParameter("@logotipo",cliente.Logotipo);
            //new SqlParameter("@",cliente);
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
