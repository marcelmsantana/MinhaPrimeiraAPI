using Camada_Dados.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camada_Dados.MER_Config
{
    public class EscolaConfig : IEntityTypeConfiguration<Escola>
    {
        public void Configure(EntityTypeBuilder<Escola> builder)
        {
            builder.HasMany(x => x.Professores);

            builder.HasMany(x => x.Alunos)
                    .WithOne(x => x.Escola)
                     .HasForeignKey(x => x.Id);
        }
    }
}
