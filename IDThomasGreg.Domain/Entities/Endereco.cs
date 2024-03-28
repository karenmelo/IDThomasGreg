using IDThomasGreg.Domain.DomainObject;

namespace IDThomasGreg.Domain.Entities
{
    public class Endereco : Entity
    {
        public Guid ClienteId { get; set; }
        public string Logradouro { get; set; }


        public Cliente Cliente { get; set; }
    }
}
