using IDThomasGreg.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IDThomasGreg.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");
                        
            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(c => c.Logotipo)
                .IsRequired()
                .HasColumnType("varchar(250)");

            // 1 : N => Cliente : Enderecos
            builder.HasMany(c => c.Endereco)
                .WithOne(p => p.Cliente)
                .HasForeignKey(p => p.ClienteId);

            builder.ToTable("Cliente");
        }
    }
}
