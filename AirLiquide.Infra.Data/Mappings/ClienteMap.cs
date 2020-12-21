using AirLiquide.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirLiquide.Infra.Data.Mappings
{
    public class ClienteMap : BaseMap<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100);
            builder.Property(c => c.Idade).IsRequired().HasColumnName("Idade");
            builder.ToTable("Clientes");
        }
    }
}
