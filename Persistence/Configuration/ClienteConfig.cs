using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.id);
            builder.ToTable("ATENCION_CLIENTE");
            builder.Property(e => e.id).HasColumnName("id_cliente");
            builder.Property(e => e.sexo).HasColumnName("sexo");
            builder.Property(e => e.nombres).HasColumnName("nombres");
            builder.Property(e => e.apellidos).HasColumnName("apellidos");
            builder.Property(e => e.telefono).HasColumnName("telefono");
            builder.Property(e => e.fecha).HasColumnName("fecha");

            builder.HasOne(e => e.idMotivoNavigator)
                .WithMany(e => e.cliente)
                .HasForeignKey(e => e.idMotivo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_motivo_cliente");
        }
    }
}
