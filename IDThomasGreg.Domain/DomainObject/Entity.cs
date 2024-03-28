namespace IDThomasGreg.Domain.DomainObject
{
    public class Entity
    {
        public Guid Id { get; set; }
               
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
