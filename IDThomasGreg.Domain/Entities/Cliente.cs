using IDThomasGreg.Domain.DomainObject;

namespace IDThomasGreg.Domain.Entities
{
    public class Cliente : Entity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Logotipo { get; private set; }

        public IEnumerable<Endereco> Endereco { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email, string logotipo, IEnumerable<Endereco> endereco)
        {
            Nome = nome;
            Email = email;
            Logotipo = logotipo;
            Endereco = endereco;
        }
    }
}
