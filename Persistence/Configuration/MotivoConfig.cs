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
    public class MotivoConfig : IEntityTypeConfiguration<Motivo>
    {
        public void Configure(EntityTypeBuilder<Motivo> builder)
        {
            builder.HasKey(e => e.id);
            builder.ToTable("motivo");
            builder.Property(e => e.id).HasColumnName("id_motivo");
            builder.Property(e => e.nombreMotivo).HasColumnName("nombreMotivo");
        }
    }
}
