using IDThomasGreg.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IDThomasGreg.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(250)");
            
            builder.ToTable("Endereco");
        }
    }
}
