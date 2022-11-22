using Camada_Dados.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camada_Dados.MER_Config
{
    public class ProfessorConfig : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasMany(x => x.Alunos)
                    .WithOne(x => x.Professor)
                     .HasForeignKey(x => x.Id);
        }
    }
}
