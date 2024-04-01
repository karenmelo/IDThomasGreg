using IDThomasGreg.Domain.Entities;

namespace IDThomasGreg.Domain.Services.Interfaces
{
    public interface IClienteService
    {
        void Criar(Cliente cliente);
        Task Atualizar(Cliente cliente);
        Task Visualizar(Guid idCliente);
        Task Remover(Guid idCliente);
    }
}
